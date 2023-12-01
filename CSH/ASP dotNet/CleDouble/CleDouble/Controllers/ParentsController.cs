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
        public class ParentsController : ControllerBase
        {
            private readonly ParentsServices _service;
            private readonly IMapper _mapper;
            public ParentsController(ParentsServices service, IMapper mapper)
            {
                _service = service;
                _mapper = mapper;
            }

            //GET api/Parents
            [HttpGet]
            public ActionResult<IEnumerable<ParentsDTOAvecEnfants>> GetAllParents()
            {
                var listeParents = _service.GetAllParents();
                return Ok(_mapper.Map<IEnumerable<ParentsDTOAvecEnfants>>(listeParents));
            }

            //GET api/Parents/{id}
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

            //POST api/GameConsoles
            [HttpPost]
            public ActionResult<ParentsDTO> CreateParent(ParentsDTO parentDto)
            {
                Parent parent = new Parent();
                _mapper.Map(parentDto, parent);
                //on ajoute l’objet à la base de données
                _service.AddParent(parent);
                //on retourne le chemin de findById avec l'objet créé
                return CreatedAtRoute(nameof(GetParentById), new { Id = parent.IdParent }, parent);
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

            [HttpPatch("{id}")]
            public ActionResult PartialParentUpdate(int id, JsonPatchDocument<Parent> patchDoc)
            {
                try
                {
                    var parentFromRepo = _service.GetParentById(id);

                    var parentToPatch = _mapper.Map<Parent>(parentFromRepo);

                    patchDoc.ApplyTo(parentToPatch, ModelState);

                    if (!TryValidateModel(parentToPatch)) return ValidationProblem(ModelState);
                    _mapper.Map(parentToPatch, parentFromRepo);
                    _service.UpdateParent(parentFromRepo);
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

            //DELETE api/Parents/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteParent(int id)
            {
                var parentFromRepo = _service.GetParentById(id);
                if (parentFromRepo == null)
                {
                    return NotFound();
                }
                _service.DeleteParent(parentFromRepo);
                return NoContent();
            }
        }

    }
