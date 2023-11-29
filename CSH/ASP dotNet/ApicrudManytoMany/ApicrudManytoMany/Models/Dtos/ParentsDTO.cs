namespace ApicrudManytoMany.Models.Dtos
{
    public class ParentsDTO
    {
        // Sans Relation
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }
    }

    public class ParentsDTOAvecEnfants
    {
        // Avec relation
        public int IdParent { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public int Age { get; set; }
        public virtual ICollection<EnfantsDTO> ListeEnfants { get; set; } = new List<EnfantsDTO>();
    }
}
