namespace Employe
{
    class Program
    {
        static void Main()
        {
            Employee e1 = new("Nolk", "Paul", new DateTime(2021,11,14), "Assistant Réseau", 28, "Informatique");
            Employee e2 = new("Chirac", "Jacques", new DateTime(1980,06,21), "Directeur général",55,"Ressources Humaines");
            Employee e3 = new("Moka", "Gerard", new DateTime(2018, 03, 17), "Comptable", 37, "Comptabilité");
            Employee e4 = new("Jun", "Ling", new DateTime(1994, 10, 01), "Secretaire", 40, "Secrétariat");
            Employee e5 = new("Evrard", "Marjorie", new DateTime(1989, 05, 26), "Chargée de Recrutement", 32, "Ressources Humaines");
            Employee e6 = new("Brio", "Maxime", new DateTime(1995, 02, 13), "Chargé de Projet", 30, "Informatique");
            e1.Afficher();
            e6.Recruterdepuis();
            e1.Prime(2);
            e2.Prime(42);
            e3.Prime(4);
            e4.Prime(29);
            e5.Prime(33);
            e6.Prime(27);
            Employe.Employee.CheckPrime();
            Employe.Employee.CompteurEmployes(); 
        }
    }
}