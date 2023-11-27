using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    public class Enfant
    {
        // Propriétés
        public string Prenom {  get; set; }
        public int Age {  get; set; }

        public Enfant(string prenom, int age)
        {
            Prenom = prenom;
            Age = age;
        }

        public override string ToString()
        {
            return "Il/Elle a un enfant qui s'appelle " + Prenom + " agé de " + Age + " ans \n";
        }

        public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
