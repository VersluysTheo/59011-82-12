using AutoMapper;
using crudapirelationnn.Models.Data;
using crudapirelationnn.Models.Dtos;

namespace crudapirelationnn.Models.Profiles
{
    public class EnfantProfile : Profile
    {
        public EnfantProfile() 
        {
            CreateMap<Enfant, EnfantDtoSansModeles>();
            CreateMap<EnfantDtoSansModeles, Enfant>();
            CreateMap<EnfantDtoAvecModeles, Enfant>().ForMember(m => m.SonParent, a => a.MapFrom(q => q.IdEnfant)); /* RELATION On donne l'info sur comment retrouver les données manquantes */
            CreateMap<Enfant, EnfantDtoAvecModeles>();
        }
    }
}