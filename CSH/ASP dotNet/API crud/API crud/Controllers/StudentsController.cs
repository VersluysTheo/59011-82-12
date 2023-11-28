using API_crud.Models.Dtos;
using API_crud.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Components;
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
        public ActionResult<IEnumerable<StudentsDTO>> getAllStudents()
        {
            var listeStudents = _service.GetAllStudents();
            return Ok(_mapper.Map<IEnumerable<StudentsDTO>>(listeStudents));
        }

    }
}
