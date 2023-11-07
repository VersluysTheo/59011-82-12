using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    internal class Agence
    {
        // Propriétés
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string Adresse { get; set; }
        private string Code_Postal { get; set; }
        private string Ville { get; set; }

        // Constructeur
        public Agence(string nom, string prenom, string adresse, string code_Postal, string ville)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Code_Postal = code_Postal;
            Ville = ville;
        }
    }
}
