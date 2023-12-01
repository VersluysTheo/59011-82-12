using AutoMapper;
using CleDouble.Models.Data;
using CleDouble.Models.Dtos;
using CleDouble.Models.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CleDouble.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EnfantsController : ControllerBase
    {
        private readonly EnfantsServices _service;
        private readonly IMapper _mapper;
        public EnfantsController(EnfantsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Enfants
        [HttpGet]
        public ActionResult<IEnumerable<EnfantsDTO>> getAllEnfants()
        {
            var listeEnfants = _service.GetAllEnfants();
            return Ok(_mapper.Map<IEnumerable<EnfantsDTO>>(listeEnfants));
        }

        //GET api/Enfants/{id}
        [HttpGet("{id}", Name = "GetEnfantById")]
        public ActionResult<EnfantsDTO> GetEnfantById(int id)
        {
            var commandItem = _service.GetEnfantById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<EnfantsDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/GameConsoles
        [HttpPost]
        public ActionResult<Enfant> CreateEnfant(EnfantsDTO enfantDto)
        {
            Enfant enfant = new Enfant();
            _mapper.Map(enfantDto, enfant);
            //on ajoute l’objet à la base de données
            _service.AddEnfant(enfant);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetEnfantById), new { Id = enfant.IdEnfant }, enfant);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEnfant(int id, EnfantsDTO enfant)
        {
            var enfantFromRepo = _service.GetEnfantById(id);
            if (enfantFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(enfant, enfantFromRepo);

            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdateEnfant(enfantFromRepo);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialEnfantUpdate(int id, JsonPatchDocument<Enfant> patchDoc)
        {
            try
            {
                var enfantFromRepo = _service.GetEnfantById(id);

                var enfantToPatch = _mapper.Map<Enfant>(enfantFromRepo);

                patchDoc.ApplyTo(enfantToPatch, ModelState);

                if (!TryValidateModel(enfantToPatch)) return ValidationProblem(ModelState);
                _mapper.Map(enfantToPatch, enfantFromRepo);
                _service.UpdateEnfant(enfantFromRepo);
            }
            catch (HttpRequestException error)
            {
                return null;
            }
            catch (Exception)
            {
                return NotFound();
            }
            return NoContent();
        }

        //DELETE api/Enfants/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEnfant(int id)
        {
            var enfantFromRepo = _service.GetEnfantById(id);
            if (enfantFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteEnfant(enfantFromRepo);
            return NoContent();
        }
    }

}
