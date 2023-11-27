using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionFichier
{
    public class Contenu
    {
        public static void Ecrire(string text, string[] lines)
        {
            string Pattern = @"U:\59011-82-12";
            if (!File.Exists(Pattern))
            {
                //Creation du texte et association dans une variable
                string texte = text + Environment.NewLine;
                string docPattern = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // ecriture dans un nouveau fichier texte
                File.WriteAllText(Path.Combine(docPattern, "Je suis un fichier.txt"), texte);

                // Associer le texte au fichier texte
                File.AppendAllLines(Path.Combine(docPattern, "Je suis un fichier.txt"), lines);
            }
        }
    }
}
