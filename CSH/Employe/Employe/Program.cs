namespace Employe
{
    class Program
    {
        static void Main()
        {
            Employee e1 = new("Nolk", "Paul", new DateTime(2021,11,14), "Assistant Réseau", 28, "Informatique");
            e1.Afficher();
            e1.Recruterdepuis();
            e1.Prime(2);
        }
    }
}