using System.Text.Json;

namespace GestionFichier
{
    internal class Program
    {
        static void Main()
        {
            string[] lines = { "Dakor", "Je comprend" };
            Contenu.Ecrire("Bonjour",lines);
        }
    }
}