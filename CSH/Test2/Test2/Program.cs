using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            // Exo1
            //Console.WriteLine("Votre Nom ?");
            //String s = Console.ReadLine();
            //Console.WriteLine("Bonjour " + s);

            // Exo 2
            //Console.Write("Votre Age ?");
            //String valeur = Console.ReadLine();
            //Int convert = Convert.ToInt32(valeur);
            //Console.WriteLine("Vous avez " + convert + " ans");

            //1.2
            // Exo 3
            //int a, b;
            //string valeur1, valeur2;
            //Console.WriteLine("a = ?");
            //valeur1 = Console.ReadLine();
            //a = Convert.ToInt32(valeur1);
            //Console.WriteLine("b = ?");
            //valeur2 = Console.ReadLine();
            //b = Convert.ToInt32(valeur2);
            //Console.WriteLine("Somme : " + (a + b) + " Quotient : " + (a / b));

            //1.3
            //Exo4 
            //Console.Write("Ecrit une valeur flottante : ");
            //String valeur = Console.ReadLine();
            //Decimal convert = Convert.ToDecimal(valeur);
            //Console.WriteLine(convert);

            //Exo5
            //string valeur1, valeur2, valeur3;
            //decimal convert, convert2, convert3;
            //Console.Write("Valeur 1 ? ");
            //valeur1 = Console.ReadLine();
            //convert = Convert.ToDecimal(valeur1);
            //Console.Write("Valeur 2 ? ");
            //valeur2 = Console.ReadLine();
            //convert2 = Convert.ToDecimal(valeur2);
            //Console.Write("Valeur 3 ? ");
            //valeur3 = Console.ReadLine();
            //convert3 = Convert.ToDecimal(valeur3);
            //Console.WriteLine("Moyenne : " +(convert + convert2 + convert3) / 3);

            //Exo6
            //string valeur, valeur1;
            //int longueur, largeur;
            //Console.Write("Longueur du Rectangle ? ");
            //string = Console.ReadLine();
            //longueur = Convert.ToInt32(valeur);
            //Console.Write("Largeur du Rectangle ? ");
            //string = Console.ReadLine();
            //largeur = Convert.ToInt32(valeur1);
            //Console.WriteLine("Aire du Rectangle : " + (longueur * largeur));

            //1.4
            //Exo 7
            //Char var = 'a';
            //int Al = Convert.ToUInt16(var);
            //Console.WriteLine(Al);


            //Exo 8 
            //String s;
            //Console.WriteLine("Ecrivez un texte : ");
            //s = Console.ReadLine();
            //Console.WriteLine(s.ToUpper());


            //2

            //Exo 1
            //String lettre;
            //int unicode, unisucc;
            //Char convert, successeur;
            //Console.WriteLine("lettre ?");
            //lettre = Console.ReadLine();
            //convert = Convert.ToChar(lettre);
            //unicode = Convert.ToUInt16(convert);
            //unisucc = (unicode + 1);
            //successeur = (Char)((int)convert + 1);
            //Console.WriteLine(lettre + " " + unicode + " " + successeur + " " + unisucc);


            //Exo 2
            //List<int> nombre = new List<int>()
            // {'1','2','3','4','5','6','7','8','9'};
            //foreach (var item in nombre)
            //{
            //    int uni = Convert.ToUInt16(item);
            //    Console.WriteLine(uni);

            //Exo 3
            //String K, M ;
            //Double carton, camion, marchandise;
            //Console.WriteLine("Masse de la Marchandise ?");
            //K = Console.ReadLine();
            //marchandise = Convert.ToDouble(K);
            //Console.WriteLine("Masse du Camion ?");
            //M = Console.ReadLine();
            //camion = Convert.ToDouble(M);
            //carton = Math.Round(camion / marchandise);
            //Console.WriteLine("Marchandise : " + marchandise + " kilos " + "Camion : "  + camion + " Kilos");
            //Console.WriteLine("Il est possible de placer " + carton + " Carton(s)");

            //Exo 4
            int cinquante, vingt, dix, cinq, deux, un;
            Double client;
            String argent;
            Console.WriteLine("Saississez une Valeur entre 0 et 0.99");
            argent = Console.ReadLine();
            client = Convert.ToDouble(argent);
            if (client < 1) {
                cinquante = 0;
                vingt = 0;
                while (client > 0.5)
                {
                    cinquante++;
                }
                while (client > 0.2)
                {
                    vingt++;
                }
                Console.WriteLine(client + " Euros");
            }
            else {
                Console.WriteLine("Tu ne sais pas lire");
            }
        }
    }
}


