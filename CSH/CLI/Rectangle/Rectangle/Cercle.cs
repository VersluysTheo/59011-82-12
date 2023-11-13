using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Cercle
    {
        public double Diametre { get; set; }
        public double Rayon { get; set; }

        public Cercle(double diametre)
        {
            Diametre = diametre;
            Rayon = diametre / 2;
        }

        public double Perimetre()
        {
            double perimetre;
            perimetre = Math.Round(2*Math.PI*Rayon ,2);
            return perimetre;
        }

        public double Aire()
        {
            double aire;
            aire = Math.Round(Math.PI*Math.Pow(Rayon,2),2);
            return aire;
        }

        public void AfficherCercle()
        {
            Console.WriteLine($"Diamètre : [{Diametre}] - Perimetre : [{Perimetre()}] - Aire : [{Aire()}]");
        }
    }
}
