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
        private void DataGrid_LostFocus(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
        }

    }
}
