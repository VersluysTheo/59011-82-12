using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCrudMultiFenetre.Models.Data
{
    internal class Produit
    {
        public string? LibelleProduit { get; set; }
        public string? Description { get; set; }
        public string? Categorie { get; set; }
        public int? Stock { get; set; }
        public int? Prix { get; set; }
    }
}
