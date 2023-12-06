using Crud_Json.Models.Data;
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
using System.Windows.Shapes;

namespace Crud_Json
{
    /// <summary>
    /// Logique d'interaction pour SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public string Mode { get; set; }
        public SecondWindow(Produits p, MainWindow w, string mode)
        {
            InitializeComponent();
            Mode = mode;
            btnSave.Content = Mode;
            RemplissageChamp(p);
        }

        public void RemplissageChamp(Produits p)
        {
            if (Mode != "Ajouter")
            {
                idProduit.Content = p.IdProduit.ToString();
                txtLibelle.Text = p.LibelleProduit;
                txtDescription.Text = p.Description;
                txtNumeroProduit.Text = p.NumeroProduit.ToString();
                txtStock.Text = p.Quantite.ToString();
                txtPrix.Text = p.Prix.ToString();
            }
            else
            {
                idProduit.Content = "0";
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Produits p = new Produits(Int32.Parse((string)idProduit.Content), txtLibelle.Text, txtDescription.Text , Int32.Parse(txtNumeroProduit.Text), Int32.Parse(txtStock.Text), Int32.Parse(txtPrix.Text));
            switch (Mode)
            {
                case "Ajouter": ProduitsServices.AddProduit(p); break;
                case "Modifier": ProduitsServices.UpdateProduit(p); break;
                case "Supprimer": ProduitsServices.DeleteProduit(p); break;
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Petit Message au cas ou il clique par accident 
            var result = MessageBox.Show("Voulez vous Vraiment quitter la fenetre ?",
                             "Question",
                             MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSave.IsEnabled = true;
        }
    }
}
