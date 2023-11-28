using API_crud.Models.Data;
using API_crud.Models.Dtos;
using API_crud.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace API_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController:ControllerBase
    {
        private readonly StudentsServices _service;
        private readonly IMapper _mapper;
        public StudentsController(StudentsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET 
        [HttpGet]
        public ActionResult<IEnumerable<StudentsDTO>> GetAllStudents()
        {
            var listeStudents = _service.GetAllStudents();
            return Ok(_mapper.Map<IEnumerable<StudentsDTO>>(listeStudents));
        }

        // GET by id
        [HttpGet("{id}", Name = "GetStudentById")]
        public ActionResult<StudentsDTO> GetStudentById(int id)
        {
            var commandItem = _service.GetStudentById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<StudentsDTO>(commandItem));
            }
            return NotFound();
        }

        //POST (Add)
        [HttpPost]
        public ActionResult<StudentsDTO> CreateStudent(Student student)
        {
            //on ajoute l’objet à la base de données
            _service.AddStudent(student);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetStudentById), new
            {
                student.Id
            }, student);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, StudentsDTO student)
        {
            var studentFromRepo = _service.GetStudentById(id);
            if (studentFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(student, studentFromRepo);
            _service.UpdateStudent(studentFromRepo);
            return NoContent();
        }

        //PATCH api/students/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialStudentUpdate(int id, JsonPatchDocument<StudentsDTO>
       patchDoc)
        {
            var studentFromRepo = _service.GetStudentById(id);
            if (studentFromRepo == null)
            {
                return NotFound();
            }
            var studentToPatch = _mapper.Map<StudentsDTO>(studentFromRepo);
            patchDoc.ApplyTo(studentToPatch, ModelState);
            if (!TryValidateModel(studentToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(studentToPatch, studentFromRepo);
            _service.UpdateStudent(studentFromRepo);
            return NoContent();
        }

        //DELETE api/students/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            var studentModelFromRepo = _service.GetStudentById(id);
            if (studentModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteStudent(studentModelFromRepo);
            return NoContent();
        }

    }
}
