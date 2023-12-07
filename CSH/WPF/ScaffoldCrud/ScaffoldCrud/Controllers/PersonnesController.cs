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
        public IEnumerable<PersonnesDTO> GetAllPersonnes()
        {
            IEnumerable<Personne> listePersonnes = _service.GetAllPersonnes();
            return _mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes);
        }
    }
}
