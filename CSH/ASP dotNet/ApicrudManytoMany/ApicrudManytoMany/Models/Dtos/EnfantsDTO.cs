namespace ApicrudManytoMany.Models.Dtos
{
    public class EnfantsDTO
    {
        // Sans relation
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }
    }

    public class EnfantsDTOAvecParent
    {
        // Avec relation
        public int IdEnfant { get; set; }
        public virtual ICollection<ParentsDTO> ListeParents { get; set; } = new List<ParentsDTO>();
    }
}
