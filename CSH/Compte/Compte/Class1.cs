using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    internal class Client
    {
        // Propriétés

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
        
        // Fonctions

        public void Afficher()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Numéro CIN : " + CIN);
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prénom : " + Prenom);
            Console.WriteLine("Téléphone : " + Telephone);
        }

        public class Compteb
        {
            // Propriétés de la classe Compte

            private Client Titulaire { get; set; } 
            private Double Solde { get; set; }
            private int Code { get; set; }

            public Compteb(Client titulaire, double solde, int code)
            {
                Titulaire = titulaire;
                Solde = solde;
                Code = code;
            }

            // Fonctions
            
            public void Crediter(double montant)
            {
                Solde += montant;
                Console.WriteLine("**********************************");
                Console.WriteLine("Donner le Montant à ajouter : " + montant);
                Console.WriteLine("Opération bien effectuée");
            }

            public void Debiter(double montant)
            {
                Solde -= montant;
                Console.WriteLine("**********************************");
                Console.WriteLine("Donner le Montant à retirer : " + montant);
                Console.WriteLine("Opération bien effectuée");
            }


            public void AfficherCompte()
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("Numéro de compte : " + Code);
                Console.WriteLine("Solde du Compte : " + Solde);
                Console.WriteLine("Propriétaire du Compte : ") ;
                Titulaire.Afficher();
            }

        }
    }
}
