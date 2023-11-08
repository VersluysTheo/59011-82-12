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
        private string Adresse { get; set; }
        private string Code_Postal { get; set; }
        private string Ville { get; set; }

        // Constructeur
        public Agence(string nom, string adresse, string code_Postal, string ville)
        {
            Nom = nom;
            Adresse = adresse;
            Code_Postal = code_Postal;
            Ville = ville;
        }

        // Fonctions 

        public override string ToString()
        {
            return "Il travaille chez " + Nom + " \n Adresse : " + Adresse + "\n Code Postal : " + Code_Postal + "\n se trouvant à " + Ville + "\n";
        }

        public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
