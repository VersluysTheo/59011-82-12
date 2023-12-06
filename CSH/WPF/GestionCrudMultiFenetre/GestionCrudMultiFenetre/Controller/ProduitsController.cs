using GestionCrudMultiFenetre.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionCrudMultiFenetre.Controller
{
    class ProduitsController
    {
        private ObservableCollection<Produit> produitsList;

        public ProduitsController(ObservableCollection<Produit> produitsList)
        {
            this.produitsList = produitsList;
        }

        public void LoadDataFromFile()
        {
            try
            {
                string filePath = "U:\\59011-82-12\\CSH\\WPF\\GestionCrudMultiFenetre\\GestionCrudMultiFenetre\\Json\\produit.json";
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    var produitsFromFile = JsonConvert.DeserializeObject<List<Produit>>(jsonContent);
                    produitsList.Clear();

                    foreach (var produit in produitsFromFile)
                    {
                        produitsList.Add(produit);
                    }
                }
                else
                {
                    MessageBox.Show("Le fichier JSON n'existe pas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des données : {ex.Message}");
            }
        }

        public void SaveDataToFile()
        {
            try
            {
                string filePath = "U:\\59011-82-12\\CSH\\WPF\\GestionCrudMultiFenetre\\GestionCrudMultiFenetre\\Json\\produit.json";
                string jsonContent = JsonConvert.SerializeObject(produitsList, Formatting.Indented);
                File.WriteAllText(filePath, jsonContent);

                MessageBox.Show("Données enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'enregistrement des données : {ex.Message}");
            }
        }
    }
}
