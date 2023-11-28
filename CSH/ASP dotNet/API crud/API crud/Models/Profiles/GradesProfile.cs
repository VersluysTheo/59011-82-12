using API_crud.Models.Data;
using API_crud.Models.Dtos;
using AutoMapper;

namespace API_crud.Models.Profiles
{
    public class GradesProfile : Profile
    {
        public GradesProfile()
        {
            CreateMap<Grade, GradesDTO>();
            CreateMap<GradesDTO, Grade>();
        }
    }
}
