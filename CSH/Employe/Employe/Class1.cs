using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    internal class Employee
    {

        //Propriétés
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date_Embauche { get; set; }
        public string Fonction { get; set; }
        public double Salaire { get; set; } // en K euros par an
        public string Service { get; set; }
        public Agence Agence { get; set; }


        private static int Nbremployes = 0;
        
        // Constructeur

        public Employee(string nom, string prenom, DateTime date_Embauche, string fonction, double salaire, string service, Agence agence)
        {
            Nom = nom;
            Prenom = prenom;
            Date_Embauche = date_Embauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
            Agence = agence;
            Nbremployes++;
        }

        public static int GetNbrEmploye()
        {
            return Nbremployes;
        }

        public static void CompteurEmployes()
        {
            // Recuperation du nombre d'instanciation
            int Nbremplo = GetNbrEmploye();
            Console.WriteLine("Il y a " + Nbremplo + " Employés");
        }

        public void Recruterdepuis()
        {
            // Comparaison de la date d'aujourd'hui et de celle de recrutement
            int embauche = DateTime.Now.Year - Date_Embauche.Year;
            if (Date_Embauche.Month > DateTime.Now.Month)
            {
                embauche--;
            }
            Console.WriteLine(Prenom + " " + Nom + " a été recruté il y a " + embauche + " ans \n");
        }

        public void Prime(double annee)
        {
            double montant = Math.Round(Salaire * (0.05+(0.02*annee)),2 );
            Console.WriteLine("Pour ses " + annee + " années d'ancienneté il touchera " + montant + " k euros de prime \n");
        }

        public static void CheckPrime()
        {
            DateTime today = DateTime.Now;
            DateTime jourprime = new DateTime(2023, 11, 08);
            if ((today.Month == jourprime.Month) && (today.Day == jourprime.Day))
            {
                Console.WriteLine("Le Versement de la prime a été effectué \n");
            } else
            {
                Console.WriteLine("Le Versement est prévu pour tout les 7 Octobre de chaque année \n");
            }

        }

        public void Afficher()
        {
            Console.WriteLine("Employe : " + Nom + " " + Prenom );
            Console.WriteLine("Date d'embauche : " + Date_Embauche);
            Console.WriteLine("Employe en tant que " + Fonction + " dans le service " + Service);
            Console.WriteLine("Salaire : " + Salaire + "k euros brut par an \n");
            Agence.Afficher();
        }
    }
}
