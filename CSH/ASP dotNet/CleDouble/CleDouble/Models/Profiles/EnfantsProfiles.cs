using AutoMapper;
using CleDouble.Models.Data;
using CleDouble.Models.Dtos;

namespace CleDouble.Models.Profiles
{
    public class EnfantsProfiles:Profile
    {
        public EnfantsProfiles()
        {
            CreateMap<Enfant, EnfantsDTO>();
            CreateMap<EnfantsDTO, Enfant>();
            CreateMap<Enfant, EnfantsDTOAvecParent>().ForMember(edto=>edto.EnfantParent,option=>option.MapFrom(p=>p.ListeParents));
            CreateMap<EnfantsDTOAvecParent,Enfant>();
        }
    }
}
