using API_crud.Models.Data;
using API_crud.Models.Dtos;
using API_crud.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace API_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController:ControllerBase
    {
        private readonly GradesServices _service;
        private readonly IMapper _mapper;

        public GradesController(GradesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET 
        [HttpGet]
        public ActionResult<IEnumerable<GradesDTO>> getAllGrades()
        {
            var listeGrades = _service.GetAllGrades();
            return Ok(_mapper.Map<IEnumerable<GradesDTO>>(listeGrades));
        }

        // GET by id
        [HttpGet("{id}", Name = "GetGradeById")]
        public ActionResult<GradesDTO> GetGradeById(int id)
        {
            var commandItem = _service.GetGradeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GradesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST (Add)
        [HttpPost]
        public ActionResult<GradesDTO> CreateGrade(Grade grade)
        {

            _service.AddGrade(grade);

            return CreatedAtRoute(nameof(GetGradeById), new
            {
                grade.GradeId
            }, grade);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateGrade(int id, GradesDTO grade)
        {
            var gradeFromRepo = _service.GetGradeById(id);
            if (gradeFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(grade, gradeFromRepo);
            _service.UpdateGrade(gradeFromRepo);
            return NoContent();
        }

        //PATCH api/grade/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialGradeUpdate(int id, JsonPatchDocument<Grade>
       patchDoc)
        {
            var gradeFromRepo = _service.GetGradeById(id);
            if (gradeFromRepo == null)
            {
                return NotFound();
            }
            var gradeToPatch = _mapper.Map<Grade>(gradeFromRepo);
            patchDoc.ApplyTo(gradeToPatch, ModelState);
            if (!TryValidateModel(gradeToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(gradeToPatch, gradeFromRepo);
            _service.UpdateGrade(gradeFromRepo);
            return NoContent();
        }

        //DELETE api/grade/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGrade(int id)
        {
            var gradeModelFromRepo = _service.GetGradeById(id);
            if (gradeModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteGrade(gradeModelFromRepo);
            return NoContent();
        }


    }
}
