using ApicrudManytoMany.Data.Models;
using ApicrudManytoMany.Models.Dtos;
using ApicrudManytoMany.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ApicrudManytoMany.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EnfantsController:ControllerBase
    {
            private readonly EnfantsServices _service;
            private readonly IMapper _mapper;
            public EnfantsController(EnfantsServices service, IMapper mapper)
            {
                _service = service;
                _mapper = mapper;
            }

            // GET 
            [HttpGet]
            public ActionResult<IEnumerable<EnfantsDTOAvecParent>> GetAllEnfants()
            {
                var listeEnfants = _service.GetAllEnfants();
                return Ok(_mapper.Map<IEnumerable<EnfantsDTOAvecParent>>(listeEnfants));
            }


            // GET by id
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

            //POST (Add)
            [HttpPost]
            public ActionResult<EnfantsDTO> CreateEnfant(EnfantsDTO enfant)
            {
                //on ajoute l’objet à la base de données
                _service.AddEnfant(_mapper.Map<Enfant>(enfant));
                //on retourne le chemin de findById avec l'objet créé
                return CreatedAtRoute(nameof(GetEnfantById), new
                {
                    enfant.IdEnfant
                }, enfant);
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
                _service.UpdateEnfant(enfantFromRepo);
                return NoContent();
            }

            //PATCH api/enfants/{id}
            [HttpPatch("{id}")]
            public ActionResult PartialEnfantUpdate(int id, JsonPatchDocument<EnfantsDTO>
           patchDoc)
            {
                var enfantFromRepo = _service.GetEnfantById(id);
                if (enfantFromRepo == null)
                {
                    return NotFound();
                }
                var enfantToPatch = _mapper.Map<EnfantsDTO>(enfantFromRepo);
                patchDoc.ApplyTo(enfantToPatch, ModelState);
                if (!TryValidateModel(enfantToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(enfantToPatch, enfantFromRepo);
                _service.UpdateEnfant(enfantFromRepo);
                return NoContent();
            }

            //DELETE api/enfants/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteEnfant(int id)
            {
                var enfantModelFromRepo = _service.GetEnfantById(id);
                if (enfantModelFromRepo == null)
                {
                    return NotFound();
                }
                _service.DeleteEnfant(enfantModelFromRepo);
                return NoContent();
            }
        }
}
