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
            Console.WriteLine("Il y a " + Nbremployes + " Employés");
        }

        public int EmbaucheAnnee()
        {
            // Comparaison de la date d'aujourd'hui et de celle de recrutement
            int embauche = DateTime.Now.Year - Date_Embauche.Year;
            if (Date_Embauche.Month - DateTime.Now.Month < 0)
            {
                embauche--;
            }
            return embauche;
        }

        public void RecruterDepuis()
        {
            Console.WriteLine(Prenom + " " + Nom + " a été recruté il y a " + EmbaucheAnnee() + " ans \n");
        }

        public void Prime()
        {
            double montant = Math.Round(Salaire * (0.05+(0.02*EmbaucheAnnee())),2 );
            Console.WriteLine("Pour ses " + EmbaucheAnnee() + " années d'ancienneté il touchera " + montant + " k euros de prime \n");
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

        public override string ToString()
        {
            return "Employe : " + Nom + " " + Prenom + "\n Date d'embauche : " + Date_Embauche + " \n Employe en tant que " + Fonction + " dans le service " + Service + " \n Salaire : " + Salaire + "k euros brut par an \n";
        }

        public void Afficher()
        {
            Console.WriteLine(ToString());
            Agence.Afficher();
        }
    }
}
