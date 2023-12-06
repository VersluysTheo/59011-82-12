using GestionCrudMultiFenetre.Controller;
using GestionCrudMultiFenetre.Models.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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

namespace GestionCrudMultiFenetre
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
            InitializeComponent();
            produitsList = new ObservableCollection<Produit>();
            produitsController = new ProduitsController(produitsList);
            produitsController.LoadDataFromFile();
            dtgProduit.ItemsSource = produitsList;
        }
        private Produit selectedProduit; // Declaration de selectedProduit dans la classe afin de l'utiliser


        //////////////////////////////////////////////////////////// Event //////////////////////////////////////////////////////////

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow newWindow = new SecondWindow();
            newWindow.ShowDialog();
        }

        private void DtgProduit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelete.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            selectedProduit = dtgProduit.SelectedItem as Produit;
        }

        //////////////////////////////////////////////////////////// Delete //////////////////////////////////////////////////////////
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Voulez vous vraiment supprimer cette donnée ?",
                 "Question",
                 MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                if (selectedProduit != null)
                {
                    produitsList.Remove(selectedProduit);
                    produitsController.SaveDataToFile();
                    MessageBox.Show("Données Supprimées avec Succés !");
                }
            }
        }
    }
}
