using AutoMapper;
using crudapirelationnn.Models.Data;
using crudapirelationnn.Models.Dtos;

namespace crudapirelationnn.Models.Profiles
{
    public class ParentEnfantProfile : Profile
    {
        public ParentEnfantProfile()
        {
            CreateMap<ParentEnfant, ParentEnfantDtoAvecModeles>();
            CreateMap<ParentEnfantDtoAvecModeles, ParentEnfant>();
            CreateMap<ParentDtoParent, ParentEnfant>();
            CreateMap<ParentEnfant, ParentDtoParent>();
            CreateMap<ParentDtoEnfant, ParentEnfant>();
            CreateMap<ParentEnfant, ParentDtoEnfant>();
        }
    }
}