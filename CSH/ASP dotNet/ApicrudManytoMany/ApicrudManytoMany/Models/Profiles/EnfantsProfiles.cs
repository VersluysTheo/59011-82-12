using ApicrudManytoMany.Data.Models;
using ApicrudManytoMany.Models.Dtos;
using AutoMapper;

namespace ApicrudManytoMany.Models.Profiles
{
    public class EnfantsProfiles:Profile
    {
        public EnfantsProfiles()
        {
            CreateMap<Enfant, EnfantsDTO>();
            CreateMap<EnfantsDTO,Enfant>();
            CreateMap<EnfantsDTOAvecParent, Enfant>();
            CreateMap<Enfant, EnfantsDTOAvecParent>();
        }
    }
}