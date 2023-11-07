using static Compte.Client;

namespace Compte
{
    class Program
    {
        static void Main()
        {
            Client c1 = new("RE658655", "Gijo", "Satoku", "0615246545");
            Client c2 = new("SH480921", "Shepard", "Helena", "0618293457");

            //Fonction Afficher dans la classe Client

            //c1.Afficher();
            //c2.Afficher();

            Compteb cb1 = new(c1, 500, 1);
            Compteb cb2 = new(c2, 2222, 1);
            cb1.Afficher();
            cb2.Afficher();

            // Fonction Compte Bancaire 

            //cb2.Debiter(150);
            //cb2.Afficher();
        }
    }
}