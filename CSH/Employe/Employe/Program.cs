using System.Security.Cryptography.X509Certificates;

namespace Employe
{
    class Program
    {
        static void Main()
        {
            //List<Employee> Employees = new();

            //Liste des Agences
            Agence a1 = new("Koulmi", "75 Rue Plop", "59760", "Suuuville", RestaurationEnum.Refectoire);
            Agence a2 = new("Nikololand", "35 Avenue Fernand", "31820", "Labolilala", RestaurationEnum.Refectoire);
            Agence a3 = new("Koulmi", "61 Boulevard Rompiche", "25640", "Dugiko", RestaurationEnum.Cantine);

            // Liste
            //Employees.Add(new Employee("Nolk", "Paul", new DateTime(2021, 11, 14), "Assistant Réseau", 28, "Informatique", a1));
            //Employees.Add(new Employee("Chirac", "Jacques", new DateTime(1980, 06, 21), "Directeur général", 55, "Ressources Humaines", a2));


            // Ajout d'employees

            Employee e1 = new("Nolk", "Paul", new DateTime(2021, 11, 14), "Assistant Réseau", 28, "Informatique", a1);
            Employee e2 = new("Chirac", "Jacques", new DateTime(1980, 06, 21), "Directeur général", 55, "Ressources Humaines", a2);
            Employee e3 = new("Moka", "Gerard", new DateTime(2018, 03, 17), "Comptable", 37, "Comptabilité", a2);
            Employee e4 = new("Jun", "Ling", new DateTime(1994, 10, 01), "Secretaire", 40, "Secrétariat", a3);
            Employee e5 = new("Evrard", "Marjorie", new DateTime(1989, 05, 26), "Chargée de Recrutement", 32, "Ressources Humaines", a1);
            Employee e6 = new("Brio", "Maxime", new DateTime(1995, 02, 13), "Chargé de Projet", 30, "Informatique", a1);

            // Fonctions pour les employes
            //e1.Afficher();
            //e6.RecruterDepuis();
            //e1.AffichePrime();
            //e2.AffichePrime();
            //e3.AffichePrime();
            //e4.AffichePrime();
            //e5.AffichePrime();
            //e6.AffichePrime();

            //Fonction Statique
            //Employee.CheckPrime();
            //Employee.CompteurEmployes();

            //Employee.AfficherSommeSalaire();


        }
    }
    // Enumeration des modes de restauration
    public enum RestaurationEnum
    {
        Cantine,
        Refectoire,
        Aucun
    }
}