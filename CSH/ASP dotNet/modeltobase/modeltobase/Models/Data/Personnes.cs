using System.ComponentModel.DataAnnotations;

namespace modeltobase.Models.Data
{
    public class Personnes
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Prenom { get; set; }
        [MaxLength(50)]
        public string Nom { get; set; }
        public int Age { get; set; }
    }
}