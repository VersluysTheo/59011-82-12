using crudapirelationnn.Models.Data;

namespace crudapirelationnn.Models.Dtos
{
    /* Relation DTO avec relation sans boucle */
    public class ParentEnfantDtoAvecModeles
    {
        public virtual Enfant? Enfant { get; set; }

        public virtual Parent? Parent { get; set; }
    }

    public class ParentDtoEnfant
    {
        public virtual EnfantDtoSansModeles? Enfant { get; set; }
    }

    public class ParentDtoParent
    {
        public virtual ParentDtoSansModeles? Parent { get; set; }
    }
}