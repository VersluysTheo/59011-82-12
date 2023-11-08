using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class TriangleRectangle
    {
        public int Base {  get; set; }
        public int Hauteur { get; set; }

        public TriangleRectangle(int @base, int hauteur)
        {
            Base = @base;
            Hauteur = hauteur;
        }
    }
}
