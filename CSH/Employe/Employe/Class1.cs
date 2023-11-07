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
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private DateTime Date_Embauche { get; set; }
        private string Fonction { get; set; }
        private double Salaire { get; set; } // en K euros par an
        private string Service { get; set; }
        
        public Employee(string nom, string prenom, DateTime date_Embauche, string fonction, double salaire, string service)
        {
            Nom = nom;
            Prenom = prenom;
            Date_Embauche = date_Embauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
        }

        public void Recruterdepuis()
        {
            int embauche = DateTime.Now.Year - Date_Embauche.Year;
            if ((Date_Embauche.Month > DateTime.Now.Month) || (Date_Embauche.Day > DateTime.Now.Day))
            {
                embauche--;
            }
            Console.WriteLine(Prenom + " " + Nom + " a été recruté il y a " + embauche + " ans");
        }

        public void Prime(double annee)
        {
            double montant = Salaire * (0.05*annee);
            Console.WriteLine("Pour ses " + annee + " années d'ancienneté il touchera " + montant + " euros de prime");
        }

        public void Afficher()
        {
            Console.WriteLine("Employe : " + Nom + " " + Prenom );
            Console.WriteLine("Date d'embauche : " + Date_Embauche);
            Console.WriteLine("Employe en tant que " + Fonction + " dans le service " + Service);
            Console.WriteLine("Salaire : " + Salaire + "k euros brut par an");
        }
    }
}
