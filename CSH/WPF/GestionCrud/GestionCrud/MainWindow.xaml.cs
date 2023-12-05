using GestionCrud.Controller;
using GestionCrud.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        // Gestion Evenement Bouton Delete
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                DeleteButton.IsEnabled = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string libelle = txtLibelle.Text;
            string description = txtDescription.Text;
            string categorie = txtCategorie.Text;
            string stock = txtStock.Text;
            decimal prix = Convert.ToDecimal(txtPrix.Text); // txtPrix => X name de la textbox concernée
            MessageBox.Show("Add");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }
    }
}
