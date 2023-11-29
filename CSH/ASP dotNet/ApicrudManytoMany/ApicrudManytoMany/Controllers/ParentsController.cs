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
    public class ParentsController:ControllerBase
    {
        private readonly ParentsServices _service;
        private readonly IMapper _mapper;
        public ParentsController(ParentsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET 
        [HttpGet]
        public ActionResult<IEnumerable<ParentsDTOAvecEnfants>> GetAllParents()
        {
            var listeParents = _service.GetAllParents();
            return Ok(_mapper.Map<IEnumerable<ParentsDTOAvecEnfants>>(listeParents));
        }


        // GET by id
        [HttpGet("{id}", Name = "GetParentById")]
        public ActionResult<ParentsDTOAvecEnfants> GetParentById(int id)
        {
            var commandItem = _service.GetParentById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ParentsDTOAvecEnfants>(commandItem));
            }
            return NotFound();
        }

        //POST (Add)
        [HttpPost]
        public ActionResult<ParentsDTO> CreateParent(ParentsDTO parent)
        {
            //on ajoute l’objet à la base de données
            _service.AddParent(_mapper.Map<Parent>(parent));
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetParentById), new
            {
                parent.IdParent
            }, parent);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateParent(int id, ParentsDTO parent)
        {
            var parentFromRepo = _service.GetParentById(id);
            if (parentFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(parent, parentFromRepo);
            _service.UpdateParent(parentFromRepo);
            return NoContent();
        }

        //PATCH api/parents/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialParentUpdate(int id, JsonPatchDocument<ParentsDTO>
       patchDoc)
        {
            var parentFromRepo = _service.GetParentById(id);
            if (parentFromRepo == null)
            {
                return NotFound();
            }
            var parentToPatch = _mapper.Map<ParentsDTO>(parentFromRepo);
            patchDoc.ApplyTo(parentToPatch, ModelState);
            if (!TryValidateModel(parentToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(parentToPatch, parentFromRepo);
            _service.UpdateParent(parentFromRepo);
            return NoContent();
        }

        //DELETE api/parents/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteParent(int id)
        {
            var parentModelFromRepo = _service.GetParentById(id);
            if (parentModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteParent(parentModelFromRepo);
            return NoContent();
        }

    }
}
