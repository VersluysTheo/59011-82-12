using AutoMapper;
using crudapirelationnn.Models.Data;
using crudapirelationnn.Models.Dtos;

namespace crudapirelationnn.Models.Profiles
{
    public class ParentProfile : Profile
    {
        public ParentProfile() 
        {
            CreateMap<Parent, ParentDtoSansModeles>();
            CreateMap<ParentDtoSansModeles, Parent>();
            CreateMap<ParentDtoAvecModeles, Parent>().ForMember(m => m.SonEnfant, a => a.MapFrom(q => q.IdParent)); /* RELATION On donne l'info sur comment retrouver les données manquantes */
            CreateMap<Parent, ParentDtoAvecModeles>();
        }
    }
}