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
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Code_Postal { get; set; }
        public string Ville { get; set; }
        public RestaurationEnum Restauration { get; set; }


        // Constructeur
        public Agence(string nom, string adresse, string code_Postal, string ville, RestaurationEnum restauration)
        {
            Nom = nom;
            Adresse = adresse;
            Code_Postal = code_Postal;
            Ville = ville;
            Restauration = restauration;
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
