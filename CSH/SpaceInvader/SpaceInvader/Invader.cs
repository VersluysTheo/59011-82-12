using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    public class Invader
    {
        public char Inv {  get; set; }

        public Invader()
        {
            Inv = '#';
        }

        public override string ToString()
        {
            return $"{Inv}";
        }
        public void AfficherInvader()
        {
            Console.WriteLine(ToString());
        }
    }
}
