using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaireetcie
{
    public class Commerciaux : Employe
    {
        public int NbDeplacement { get; set; }
        public int NbPrime { get; set; }

        public Commerciaux(string nom, string prenom, int age, double salaire, int nbDeplacement, int nbPrime) : base(nom,prenom,age,salaire)
    {
        NbDeplacement = nbDeplacement;
        NbPrime = nbPrime;
    }

    }
}
