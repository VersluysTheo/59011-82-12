using AutoMapper;
using crudapirelationnn.Models.Data;
using crudapirelationnn.Models.Dtos;
using crudapirelationnn.Models.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace crudapirelationnn.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EnfantController : ControllerBase
    {

        private readonly EnfantService _service;
        private readonly IMapper _mapper;

        public EnfantController(EnfantService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]/* RELATION DTO Avec relation mais sans boucle*/
        public ActionResult<IEnumerable<EnfantDtoAvecModeles>> GetAllEnfants()
        {
            var listeEnfants = _service.GetAllEnfants();
            return Ok(_mapper.Map<IEnumerable<EnfantDtoAvecModeles>>(listeEnfants));
        }

        [HttpGet("{id}", Name = "GetEnfantById")]/* RELATION DTO Avec relation mais sans boucle */
        public ActionResult<EnfantDtoAvecModeles> GetEnfantById(int id)
        {
            var modeleItem = _service.GetEnfantById(id);
            if (modeleItem != null)
            {
                return Ok(_mapper.Map<EnfantDtoAvecModeles>(modeleItem));
            }
            return NotFound();
        }

        [HttpPost]/* RELATION DTO Sans relation */
        public ActionResult<EnfantDtoSansModeles> CreateEnfant(EnfantDtoSansModeles modele)
        {
            _service.AddEnfant(_mapper.Map<Enfant>(modele));
            return CreatedAtRoute(nameof(GetEnfantById), new { Id = modele.IdEnfant }, modele);
        }

        [HttpPut("{id}")]/* RELATION DTO Sans relation */
        public ActionResult UpdateEnfant(int id, EnfantDtoSansModeles modele)
        {
            var modeleFromRepo = _service.GetEnfantById(id);
            if (modeleFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(modele, modeleFromRepo);
            _service.UpdateEnfant(modeleFromRepo);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialEnfantUpdate(int id, JsonPatchDocument<Enfant> patchDoc)
        {
            var modeleFromRepo = _service.GetEnfantById(id);
            if (modeleFromRepo == null)
            {
                return NotFound();
            }

            var modeleToPatch = _mapper.Map<Enfant>(modeleFromRepo);
            patchDoc.ApplyTo(modeleToPatch, ModelState);

            if (!TryValidateModel(modeleToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(modeleToPatch, modeleFromRepo);
            _service.UpdateEnfant(modeleFromRepo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEnfant(int id)
        {
            var modeleModelFromRepo = _service.GetEnfantById(id);
            if (modeleModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteEnfant(modeleModelFromRepo);
            return NoContent();
        }
    }
}