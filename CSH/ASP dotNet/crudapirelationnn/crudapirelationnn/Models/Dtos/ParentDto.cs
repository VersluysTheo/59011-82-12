using crudapirelationnn.Models.Data;

namespace crudapirelationnn.Models.Dtos
{
    /* Relation DTO avec relation sans boucle */
    public class ParentDtoAvecModeles
    {
        public int IdParent { get; set; }

        public string? Nom { get; set; }

        public string? Prenom { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<ParentDtoParent> SonEnfant { get; set; } = new List<ParentDtoParent>();
    }

    /* Relation DTO sans relation */
    public class ParentDtoSansModeles
    {
        public int IdParent { get; set; }

        public string? Nom { get; set; }

        public string? Prenom { get; set; }

        public int? Age { get; set; }
    }
}