using Crud_Json.Models.Data;
using Crud_Json.Models.Service;
using Crud_Json.Service;
using System;
using System.Collections.Generic;
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

namespace Crud_Json
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RemplirGrid();
        }

        private void RemplirGrid()
        {
            dtgProduit.ItemsSource = ProduitsServices.GetAllProduits();
            dtgCategorie.ItemsSource = CategoriesServices.GetAllCategories();
        }


        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {
            Produits item;
            if (((Button)sender).Name == "btnAdd")
            {
                item = new Produits();
            }
            else
            {
                item = (Produits)dtgProduit.SelectedItem;
            }

            Window w = new SecondWindow(item, this, (string)((Button)sender).Content);
            w.ShowDialog();
            RemplirGrid();
        }
        private void Row_DoubleClick(object sender, EventArgs e)
        {
            Produits item = (Produits)((DataGridRow)sender).Item;

            Window w = new SecondWindow(item, this, "Modifier");
            w.ShowDialog();
            RemplirGrid();
        }

        private void Dtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;
        }
    }
}
