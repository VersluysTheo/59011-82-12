using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public Rectangle(int longueur, int largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }
        public int Perimetre()
        {
            int perimetre;
            perimetre = Longueur*2 + Largeur*2;
            return perimetre;
        }

        public int Aire()
        {
            int aire;
            aire = Longueur * Largeur;
            return aire;
        }

        public bool EstCarre()
        {
            return (Longueur == Largeur); 
        }

        public void AfficherRectangle()
        {
            string s = "";
            if (EstCarre())
            {
                s += "Il s'agit d'un carré";
            } else
            {
                s += " Il ne s'agit pas d'un carré";
            }
            Console.WriteLine($"Longueur : [{Longueur}] - Largeur :[{Largeur}] - Périmètre : [{Perimetre()}] - Aire : [{Aire()}] - {s}");
        }
    }
}
