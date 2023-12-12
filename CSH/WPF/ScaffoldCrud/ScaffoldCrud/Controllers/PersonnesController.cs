using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScaffoldCrud.Models.Data;
using ScaffoldCrud.Models.DTOS;
using ScaffoldCrud.Models.Profiles;
using ScaffoldCrud.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldCrud.Controllers
{
    public class PersonnesController : ControllerBase
    {
        private readonly PersonnesServices _service;
        private readonly IMapper _mapper;

        public PersonnesController(PersonnesDbContext context)
        {
            _service = new PersonnesServices(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PersonnesProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        public IEnumerable<Personne> GetAllPersonnes()
        {
            IEnumerable<Personne> listePersonnes = _service.GetAllPersonnes();
            return _mapper.Map<IEnumerable<Personne>>(listePersonnes);
        }
        public ActionResult<PersonnesDTO> GetPersonneById(uint id)
        {
            var item = _service.GetPersonneById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<PersonnesDTO>(item));
            }
            return NotFound();
        }
        public ActionResult<PersonnesDTO> CreatePersonne(PersonnesDTO personneDTO)
        {
            Personne personnePOCO = _mapper.Map<Personne>(personneDTO);
            //on ajoute l’objet à la base de données
            _service.AddPersonnes(personnePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new { personneId = personnePOCO.Id }, personnePOCO);

        }

        public ActionResult UpdatePersonne( uint id, PersonnesDTO personneDTO)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(personneDTO, personneFromRepo );
            _service.UpdatePersonne(personneFromRepo);

            return NoContent();
        }

        public ActionResult DeletePersonne(uint id)
        {
            var personneModelFromRepo = _service.GetPersonneById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeletePersonne(personneModelFromRepo);

            return NoContent();
        }
    }
}
