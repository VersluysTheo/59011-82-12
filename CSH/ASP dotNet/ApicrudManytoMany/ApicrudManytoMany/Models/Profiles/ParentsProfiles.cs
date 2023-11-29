using ApicrudManytoMany.Data.Models;
using ApicrudManytoMany.Models.Dtos;
using AutoMapper;

namespace ApicrudManytoMany.Models.Profiles
{
    public class ParentsProfiles : Profile
    {
        public ParentsProfiles()
        {
            CreateMap<Parent, ParentsDTO>();
            CreateMap<ParentsDTO, Parent>();
            CreateMap<ParentsDTOAvecEnfants, Parent>();
            CreateMap<Parent, ParentsDTOAvecEnfants>();
        }
    }
}
