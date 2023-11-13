using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Sphere : Cercle
    {
        public Sphere(double diametre) : base(diametre) { }

        public double PerimetreSphere()
        {
            double perimetre;
            perimetre = Math.Round(2*Math.PI*Rayon);
            return perimetre;
        }

        public double Volume()
        {
            double volume;
            volume = Math.Round((4*(Math.PI)*Math.Pow(Rayon,3))/3,2);
            return volume;
        }

        public void AfficherSphere()
        {
            Console.WriteLine($"Diametre : [{Diametre}] - Perimètre : [{PerimetreSphere()}] - Volume : [{Volume()}]");
        }
    }
}
