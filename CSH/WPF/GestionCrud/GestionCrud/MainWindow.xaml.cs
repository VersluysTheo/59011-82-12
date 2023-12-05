using GestionCrud.Controller;
using GestionCrud.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GestionCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produit> produitsList;
        private ProduitsController produitsController;


        public MainWindow()
        {
            // Initialisation
            InitializeComponent();
            produitsList = new ObservableCollection<Produit>();
            produitsController = new ProduitsController(produitsList);
            produitsController.LoadDataFromFile();
            dtgProduit.ItemsSource = produitsList;
        }

        private Produit selectedProduit;

        // Gestion Evenement Bouton Delete
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
            if (dtgProduit.SelectedItem != null)
            {
                selectedProduit = dtgProduit.SelectedItem as Produit;

                if (selectedProduit != null)
                {
                    txtLibelle.Text = selectedProduit.LibelleProduit;
                    txtDescription.Text = selectedProduit.Description;
                    txtCategorie.Text = selectedProduit.Categorie;
                    txtStock.Text = selectedProduit.Stock.ToString();
                    txtPrix.Text = selectedProduit.Prix.ToString();
                }
            }
        }

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
        }

        ////////////////////////////////////////////////////////////////////////// Add /////////////////////////////////////////////////////////////////////
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string libelle = txtLibelle.Text;
            string description = txtDescription.Text;
            string categorie = txtCategorie.Text;
            int stock = Convert.ToInt32(txtStock.Text);
            int prix = Convert.ToInt32(txtPrix.Text); // txtPrix => X name de la textbox concernée

            Produit nouveauProduit = new Produit
            {
                LibelleProduit = libelle,
                Description = description,
                Categorie = categorie,
                Stock = stock,
                Prix = prix
            };

            produitsController.SaveDataToFile();

            produitsList.Add(nouveauProduit);
            ClearTextBox();
        }

        /////////////////////////////////////////////////////////////// UPDATE //////////////////////////////////////////////////////////
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Verification pour le libelle Produit
            if (TryParseString(txtLibelle.Text, out string newLibelle))
            {
                if (selectedProduit != null)
                {
                    selectedProduit.LibelleProduit = newLibelle;
                }
            }
            else
            {
                ConversionError("libelle");
                return;
            }

            //Verification pour la Description
            if (TryParseString(txtDescription.Text, out string newDescription))
            {
                if (selectedProduit != null)
                {
                    selectedProduit.Description = newDescription;
                }
            }
            else
            {
                ConversionError("description");
                return;
            }

            //Verification pour la Categorie
            if (TryParseString(txtCategorie.Text, out string newCategorie))
            {
                if (selectedProduit != null)
                {
                    selectedProduit.Categorie = newCategorie;
                }
            }
            else
            {
                ConversionError("categorie");
                return;
            }

            // Verification pour le Stock
            if (TryParseInt(txtStock.Text, out int newStock))
            {
                if (selectedProduit != null)
                {
                    selectedProduit.Stock = newStock;
                }
            }
            else
            {
                ConversionError("stock");
                return;
            }

            // Verification pour le Prix
            if (TryParseInt(txtPrix.Text, out int newPrix))
            {
                if (selectedProduit != null)
                {
                    selectedProduit.Prix = newPrix;
                }
            }
            else
            {
                ConversionError("stock");
                return;
            }
            produitsController.SaveDataToFile();
            dtgProduit.Items.Refresh();
            ClearTextBox();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }

        //Parse

        private static bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        private static bool TryParseString(string input,out string result)
        {
            result = input;
            return true;
        }

        // Erreur

        private static void ConversionError(string fieldname)
        {
            MessageBox.Show($"Valeur non valide pour le champ : {fieldname}");
        }

        //Vider les TextBox
        private void ClearTextBox()
        {
            txtLibelle.Text = "";
            txtDescription.Text = "";
            txtCategorie.Text = "";
            txtStock.Text = "";
            txtPrix.Text = "";
        }
    }
}


