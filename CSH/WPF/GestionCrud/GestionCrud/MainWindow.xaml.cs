using GestionCrud.Data;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Exemple d'utilisation avec une classe Produit
            GestionnaireJson<Produit> gestionnaireJson = new GestionnaireJson<Produit>("U:\\59011-82-12\\CSH\\WPF\\GestionCrud\\GestionCrud\\Json\\produit.json");

            // Uploader des données
            Produit produit = new Produit { /* initialisez les propriétés de votre produit ici */ };
            gestionnaireJson.UploadData(produit);

            // Télécharger des données
            Produit produitTelecharge = gestionnaireJson.DownloadData();
        }


        public class GestionnaireJson<Produit>
        {
            private readonly string cheminFichier;

            public GestionnaireJson(string cheminFichier)
            {
                this.cheminFichier = cheminFichier;
            }

            public void UploadData(Produit data)
            {
                try
                {
                    string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                    File.WriteAllText(cheminFichier, jsonData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur lors de l'upload des données");
                }
            }

            public Produit DownloadData()
            {
                try
                {
                    if (File.Exists(cheminFichier))
                    {
                        string jsonData = File.ReadAllText(cheminFichier);
                        return JsonConvert.DeserializeObject<Produit>(jsonData);
                    }
                    else
                    {
                        Console.WriteLine("Le fichier n'existe pas.");
                        return default(Produit);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur lors du téléchargement des données");
                    return default(Produit);
                }
            }
        }
    }
}
