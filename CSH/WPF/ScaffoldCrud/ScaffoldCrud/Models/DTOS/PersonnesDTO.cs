using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldCrud.Models.DTOS
{
    public class PersonnesDTO
    {
        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public string? Adresse { get; set; }

        public string? Ville { get; set; }
    }
}
