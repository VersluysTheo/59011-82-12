using GestionDonnee.Views;
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

namespace GestionDonnee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Articles(object sender, RoutedEventArgs e)
        {
            Window Articrud = new CrudArticles();
            Articrud.Show();
        }

        private void Button_Click_Categorie(object sender, RoutedEventArgs e)
        {
            Window CategorieCrud = new CrudCategories();
            CategorieCrud.Show();
        }
        
        private void Button_Click_TypeProduit(object sender, RoutedEventArgs e)
        {
            Window TypeProduitCrud = new TypeProduits();
            TypeProduitCrud.Show();
        }
    }
}
