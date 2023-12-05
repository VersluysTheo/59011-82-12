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

        // Methode pour ajouter des donnees
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string libelle = txtLibelle.Text;
            string description = txtDescription.Text;
            string categorie = txtCategorie.Text;
            string stock = txtStock.Text;
            int prix = Convert.ToInt32(txtPrix.Text); // txtPrix => X name de la textbox concernée

            Produit nouveauProduit = new Produit
            {
                LibelleProduit = libelle,
                Description = description,
                Categorie = categorie,
                Stock = stock,
                Prix = prix
            };

            produitsList.Add(nouveauProduit);
            // Vider les Textbox
            txtLibelle.Text = "";
            txtDescription.Text = "";
            txtCategorie.Text = "";
            txtStock.Text = "";
            txtPrix.Text = "";

            MessageBox.Show("Nouveau Produit Ajouté");
        }

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
            if (TryParseString(txtDescription.Text, out string newCategorie))
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
            if (TryParseString(txtStock.Text, out string newStock))
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
            dtgProduit.Items.Refresh();

            MessageBox.Show("Mise à jour des données");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }

        //Parse

        private bool TryParseString(string input,out string result)
        {
            result = input;
            return true;
        }

        // Erreur

        private void ConversionError(string fieldname)
        {
            MessageBox.Show($"Valeur non valide pour le champ : {fieldname}");
        }
    }
}


