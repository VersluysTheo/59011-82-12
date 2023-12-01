using AutoMapper;
using CleDouble.Models.Data;
using CleDouble.Models.Dtos;

namespace CleDouble.Models.Profiles
{
    public class ParentsProfiles:Profile
    {
        public ParentsProfiles()
        {
            CreateMap<Parent,ParentsDTO>();
            CreateMap<ParentsDTO,Parent>();
            CreateMap<Parent, ParentsDTOAvecEnfants>().ForMember(pdto=>pdto.ParentEnfant,option=>option.MapFrom(p=>p.ListeEnfants));
            CreateMap<ParentsDTOAvecEnfants,Parent>();
        }
    }
}
