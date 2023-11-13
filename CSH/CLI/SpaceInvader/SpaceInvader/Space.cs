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
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public char[,] Grille { get; set; }

        // Constructeur

        public Space(int nbLignes, int nbColonnes)
        {
            this.NbLignes = nbLignes;
            this.NbColonnes = nbColonnes;
            Grille = InitGrille();
        }
        
        // Création de la grille 
        public char[,] InitGrille()
        {
            char[,] Grille = new char[NbLignes,NbColonnes]; // Creation d'un tableau a deux dimensions vide
            for (int i = 0; i < NbLignes; i++) // Creation du nombre de Lignes
            {
                for (int j = 0 ; j < NbColonnes; j++) // Creation du nombre de Colonnes
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
