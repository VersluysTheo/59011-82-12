using ApicrudManytoMany.Data.Models;
using ApicrudManytoMany.Models.Dtos;
using AutoMapper;

namespace ApicrudManytoMany.Models.Profiles
{
    public class ParentsEnfantsProfiles : Profile
    {
        public ParentsEnfantsProfiles()
        {
            CreateMap<ParentEnfant, ParentsEnfantsDTO>();
            CreateMap<ParentsEnfantsDTO, ParentEnfant>();
            CreateMap<ParentDTOParent, ParentEnfant>();
            CreateMap<ParentEnfant, ParentDTOParent>();
            CreateMap<EnfantDTOEnfant, ParentEnfant>();
            CreateMap<ParentEnfant, EnfantDTOEnfant>();
        }
    }
}
