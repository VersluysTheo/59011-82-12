using crudapirelationnn.Models.Data;

namespace crudapirelationnn.Models.Dtos
{
    /* Relation DTO avec relation sans boucle */
    public class EnfantDtoAvecModeles
    {
        public int IdEnfant { get; set; }

        public string? Nom { get; set; }

        public string? Prenom { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<ParentDtoParent> SonParent { get; set; } = new List<ParentDtoParent>();
    }

    /* Relation DTO sans relation */
    public class EnfantDtoSansModeles
    {
        public int IdEnfant { get; set; }

        public string? Nom { get; set; }

        public string? Prenom { get; set; }

        public int? Age { get; set; }
    }
}