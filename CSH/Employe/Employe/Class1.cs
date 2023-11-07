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
        private double Salaire { get; set; }
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
    }
}
