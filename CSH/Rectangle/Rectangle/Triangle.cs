using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Triangle
    {
        public double Base {  get; set; }
        public double Hauteur { get; set; }

        public Triangle(double @base, double hauteur)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        public double Perimetre()
        {
            double perimetre;
            perimetre = Math.Round(Base + Hauteur + Math.Sqrt(Math.Pow(Base,2)+Math.Pow(Hauteur,2)),2);
            return perimetre;
        }

        public void AfficherTriangle()
        {
            Console.WriteLine($"Base : [{Base}] - Hauteur :[{Hauteur}] - Périmètre : [{Perimetre()}] -");
        }
    }
}
