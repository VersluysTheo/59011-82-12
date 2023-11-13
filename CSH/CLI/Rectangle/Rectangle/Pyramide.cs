using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Pyramide : Triangle
    {
        public Pyramide (double @base, double hauteur) : base (@base, hauteur) { }
        public double PerimetrePyra()
        {
            double perimetre;
            perimetre = (Perimetre() * 2)+(Hauteur*3);
            return perimetre;
        }

        public double Volume()
        {
            double volume;
            volume = Aire()*Hauteur;
            return volume;
        }

        public void AfficherPyra()
        {
            Console.WriteLine($"Base : [{Base}] - Hauteur : [{Hauteur}] - Perimètre : [{PerimetrePyra()}] - Volume : [{Volume()}]");
        }
    }
}
