using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    internal class Voiture
    {

        // Propriétés
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Nb_de_kilometre { get; set; }
        public string Motorisation { get; set; }

        //Differents Constructeurs

        public Voiture(string couleur, string marque, string modele, int nb_de_kilometre, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            Nb_de_kilometre = nb_de_kilometre;
            Motorisation = motorisation;
        }


        // Getter et Setter Methode 1
        //public string Couleur { get => couleur; set couleur = value; }

        // Getter et Setter Methode 2

        //public string GetCouleurVoiture()
        //{
        //    return Couleur;
        //}

        //public void SetCouleurVoiture(string value)
        //{
        //    Couleur = value;
        //}

        public override string ToString()
        {
            return "Cette voiture est une " + Modele + " de la marque " + Marque + ",de couleur " + Couleur + ",de motorisation " + Motorisation + ",avec " + Nb_de_kilometre + " Kilomètres";
        }

        public int Rouler(int nbkmroule)
        {
            return Nb_de_kilometre += nbkmroule;
        }

    }
}
