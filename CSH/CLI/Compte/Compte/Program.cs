using static Compte.Client;

namespace Compte
{
    class Program
    {
        static void Main()
        {
            Client c1 = new("RE658655", "Gijo", "Satoku", "0615246545");
            Client c2 = new("SH480921", "Shepard", "Helena", "0618293457");

            //c1.Afficher();
            //c2.Afficher();

            Compteb cb1 = new(c1, 500, 1);
            c1.Lescomptes.Add(cb1);
            Compteb cb2 = new(c2, 2222, 1);
            c2.Lescomptes.Add(cb2);
            Compteb cb3 = new(c1, 325, 2);
            c1.Lescomptes.Add(cb3);


            cb1.AfficherCompte();
            cb2.Debiter(153);
            cb2.AfficherCompte();
        }
    }
}