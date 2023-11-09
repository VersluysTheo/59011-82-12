using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    public class Space
    {
        // Propriétés
        public int nbLignes { get; set; }
        public int nbColonnes { get; set; }
        public char[,] Grille { get; set; }

        // Constructeur

        public Space(int nbLignes, int nbColonnes)
        {
            this.nbLignes = nbLignes;
            this.nbColonnes = nbColonnes;
            Grille = InitGrille();
        }
        
        public char[,] InitGrille()
        {
            char[,] Grille = new char[nbLignes,nbColonnes];
            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0 ; j < nbColonnes; j++)
                {
                    Grille[i,j] = ' ';
                }
            }
            return Grille;
        }

        public override string ToString()
        {
            string s;
            s = "";
            for (int i = 0; i < Grille.GetLength(0); i++)
            {
                s+= "|";
                for (int j = 0; j < Grille.GetLength(1); j++)
                {
                    s += Grille[i, j] ;
                }
                s += "|\n" ;
            }
            return s;

        }

        public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
