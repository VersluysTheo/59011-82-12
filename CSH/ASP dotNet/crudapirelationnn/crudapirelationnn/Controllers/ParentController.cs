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
    public class ParentController : ControllerBase
    {

        private readonly ParentService _service;
        private readonly IMapper _mapper;

        public ParentController(ParentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]/* RELATION DTO Avec relation mais sans boucle*/
        public ActionResult<IEnumerable<ParentDtoAvecModeles>> GetAllParents()
        {
            var listeParents = _service.GetAllParents();
            return Ok(_mapper.Map<IEnumerable<ParentDtoAvecModeles>>(listeParents));
        }

        [HttpGet("{id}", Name = "GetParentById")]/* RELATION DTO Avec relation mais sans boucle */
        public ActionResult<ParentDtoAvecModeles> GetParentById(int id)
        {
            var modeleItem = _service.GetParentById(id);
            if (modeleItem != null)
            {
                return Ok(_mapper.Map<ParentDtoAvecModeles>(modeleItem));
            }
            return NotFound();
        }

        [HttpPost]/* RELATION DTO Sans relation */
        public ActionResult<ParentDtoSansModeles> CreateParent(ParentDtoSansModeles modele)
        {
            _service.AddParent(_mapper.Map<Parent>(modele));
            return CreatedAtRoute(nameof(GetParentById), new { Id = modele.IdParent }, modele);
        }

        [HttpPut("{id}")]/* RELATION DTO Sans relation */
        public ActionResult UpdateParent(int id, ParentDtoSansModeles modele)
        {
            var modeleFromRepo = _service.GetParentById(id);
            if (modeleFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(modele, modeleFromRepo);
            _service.UpdateParent(modeleFromRepo);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialParentUpdate(int id, JsonPatchDocument<Parent> patchDoc)
        {
            var modeleFromRepo = _service.GetParentById(id);
            if (modeleFromRepo == null)
            {
                return NotFound();
            }

            var modeleToPatch = _mapper.Map<Parent>(modeleFromRepo);
            patchDoc.ApplyTo(modeleToPatch, ModelState);

            if (!TryValidateModel(modeleToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(modeleToPatch, modeleFromRepo);
            _service.UpdateParent(modeleFromRepo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteParent(int id)
        {
            var modeleModelFromRepo = _service.GetParentById(id);
            if (modeleModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteParent(modeleModelFromRepo);
            return NoContent();
        }
    }
}