using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    internal class Client
    {
        // Attrbuts

        private string CIN { get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; } 
        private string Telephone {  get; set; }

        // Constructeur
        public Client(string cIN, string nom, string prenom, string telephone)
        {
            CIN = cIN;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public void Afficher()
        {
            Console.WriteLine("Numéro CIN : " + CIN);
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prénom : " + Prenom);
            Console.WriteLine("Téléphone : " + Telephone);
        }

        public class Compte
        {
            // Propriétés de la classe Compte
            private int Solde { get; set; }
            private int Code { get; set; }

            public Compte(int solde, int code)
            {
                Solde = solde;
                Code = code;
            }
        }
    }
}
