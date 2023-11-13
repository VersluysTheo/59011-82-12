using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaireetcie
{
    public abstract class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public double Salaire { get; set; }

        public Employe(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public double CalculSalaire()
        {
            double calcsalaire;
            calcsalaire = Salaire;
            return calcsalaire;
        }

        public override string ToString()
        {
            return $"Nom : {Nom} \tPrenom : {Prenom} \tAge : {Age} \tSalaire : {Salaire}";
        }

        public void Afficher()
        {
            Console.WriteLine(ToString()); ;
        }
    }
}
