using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaireetcie
{
    public class Entreprise
    {
        public string Nom {  get; set; }
        public List<Commerciaux> ListeCommerciaux { get; set; }
        public List<Technicien> ListeTechniciens { get; set; }

        public Entreprise(string nom, List<Commerciaux> listeCommerciaux, List<Technicien> listeTechniciens)
        {
            Nom = nom;
            ListeCommerciaux = listeCommerciaux;
            ListeTechniciens = listeTechniciens;
        }
    }
}
