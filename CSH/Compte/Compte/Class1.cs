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
        public List<Compteb> Lescomptes { get; set; }

        // Constructeur
        public Client(string cIN, string nom, string prenom, string telephone)
        {
            CIN = cIN;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Lescomptes = new List<Compteb>();
        }

        // Fonctions


        public void Afficher()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Numéro CIN : " + CIN);
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prénom : " + Prenom);
            Console.WriteLine("Téléphone : " + Telephone);

            // Essai d'affichage des valeurs de la liste -> sans succes
            //foreach (int j in Lescomptes)
            //{
            //    Console.WriteLine(j);
            //}
        }

        public class Compteb
        {
            // Propriétés de la classe Compte

            private Client Titulaire { get; set; } 
            private Double Solde { get; set; }
            private int Code { get; set ; }

            private static int compteCounter = 0;


            //Construct 

            public Compteb(Client titulaire, double solde, int code)
            {
                Titulaire = titulaire;
                Solde = solde;
                Code = code;
                ++compteCounter;
            }

            // Fonctions

            public static int GetNombreComptesCrees()
            {
                return compteCounter;
            }

            public void Crediter(double montant)
            {
                Solde += montant;
                Console.WriteLine("**********************************");
                Console.WriteLine("Donner le Montant à ajouter : " + montant);
                Console.WriteLine("Opération bien effectuée");
            }


            // Incorrect
            //public void Creditercompte(int compte, double montant)
            //{
            //    Code = compte;
            //    Solde += montant;
            //    Console.WriteLine("**********************************");
            //    Console.WriteLine("N° de Compte voulu : " + Code);
            //}

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
