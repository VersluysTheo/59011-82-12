using AutoMapper;
using ScaffoldCrud.Models.Data;
using ScaffoldCrud.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldCrud.Models.Profiles
{
    public class PersonnesProfiles : Profile
    {
        public PersonnesProfiles()
        {
            CreateMap<Personne, PersonnesDTO>();
            CreateMap<PersonnesDTO, Personne>();
        }
    }
}
