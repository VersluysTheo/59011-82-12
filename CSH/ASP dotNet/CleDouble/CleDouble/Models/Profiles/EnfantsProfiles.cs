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
        }
    }
}
