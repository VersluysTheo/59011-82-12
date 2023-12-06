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
        public int NumeroProduit { get; set; }
        public int Quantite { get; set; }
        public int Prix { get; set; }

        public Produits(int idProduit, string libelleProduit, int numeroProduit, int quantite, int prix)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            NumeroProduit = numeroProduit;
            Quantite = quantite;
            Prix = prix;
        }
    }
}
