namespace Voiture
{

    class Wouhou
    {
        static void Main()
        {
            Voiture v1 = new Voiture("Noir", "Citröen" , "C4", 100000, " Essence");
            Voiture v2 = new Voiture("Rouge", "Renault", "Kadjar", 251656, " Diesel");
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2);
            v1.Rouler(289);
            Console.WriteLine(v1);
        }
    }
}
