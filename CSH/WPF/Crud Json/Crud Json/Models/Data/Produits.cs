using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Json.Models.Data
{
    public class Produits
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string Description { get; set; }
        public int NumeroProduit { get; set; }
        public int Quantite { get; set; }
        public int Prix { get; set; }

        public Produits(int idProduit, string libelleProduit,string description , int numeroProduit, int quantite, int prix)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Description = description;
            NumeroProduit = numeroProduit;
            Quantite = quantite;
            Prix = prix;
        }

        public Produits()
        {
        }
    }
}
