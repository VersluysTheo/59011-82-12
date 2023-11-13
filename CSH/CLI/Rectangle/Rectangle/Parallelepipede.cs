using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Parallelepipede : Rectangle
    {
        // Propriétés
        public int Hauteur {  get; set; }

        // Constructeur
        public Parallelepipede (int longueur,int largeur,int hauteur) : base(longueur,largeur)
        {
            Hauteur = hauteur;
        }

        public int PerimetrePara()
        {
            int perimetre;
            perimetre = (Perimetre()*2)+(Hauteur*4);
            return perimetre;
        }

        public int Volume()
        {
            int volume;
            volume = Aire()*Hauteur;
            return volume;
        }

        public void AfficherPara()
        {
            Console.WriteLine($"Longueur : [{Longueur}] - Largeur : [{Largeur}] - Hauteur : [{Hauteur}] - Perimètre : [{PerimetrePara()}] - Volume : [{Volume()}]");
        }
    }
}
