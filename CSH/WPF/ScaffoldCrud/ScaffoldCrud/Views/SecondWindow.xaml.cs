using ScaffoldCrud.Controllers;
using ScaffoldCrud.Models.Data;
using ScaffoldCrud.Models.DTOS;
using ScaffoldCrud.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ScaffoldCrud.Views
{
    /// <summary>
    /// Logique d'interaction pour SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        uint Id { get; set; }
        string Mode { get; set; }
        MainWindow Mw { get; set; }
        public SecondWindow(Personne item,MainWindow mw, string mode)
        {
            InitializeComponent();
            RemplisageForm(item);
            Id = item.Id;
            Mw = mw;
            Mode = mode;
            if ( Mode == "Supprimer")
            {
                txtNom.IsEnabled = false;
                txtPrenom.IsEnabled = false;
                txtCodePostal.IsEnabled = false;
                txtAdresse.IsEnabled = false;
                txtVille.IsEnabled = false;
            }

        }

        public void RemplisageForm(Personne item)
        {
            txtNom.Text = item.Nom;
            txtPrenom.Text = item.Prenom;
            txtCodePostal.Text = Convert.ToString(item.CodePostal);
            txtAdresse.Text = item.Adresse;
            txtVille.Text = item.Ville;
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSave.IsEnabled = true;
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


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {             

            if (Mode == "Modifier")
            {
                var result = MessageBox.Show("Voulez vous sauvegarder les données ?",
                 "Question",
                 MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    ModifierPersonne();
                    MessageBox.Show("Personne Modifiée");
                }
            }
            else if (Mode == "Ajouter") 
            {
                var result = MessageBox.Show("Voulez vous ajouter cette personne à la base de données ?",
                "Question",
                MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    AjouterPersonne();
                    MessageBox.Show("Personne Ajoutée");
                }
            }
            else if (Mode == "Supprimer")
            {
                var result = MessageBox.Show("Voulez vous supprimer cette personne ?",
                "Question",
                MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    SupprimerPersonne();
                    MessageBox.Show("Personne Supprimée");
                }
            }
        }

        private void AjouterPersonne()
        {
            PersonnesDTO persoDTO = new PersonnesDTO();
            persoDTO.Nom = txtNom.Text;
            persoDTO.Prenom = txtPrenom.Text;
            persoDTO.CodePostal = Int32.Parse(txtCodePostal.Text);
            persoDTO.Adresse = txtAdresse.Text;
            persoDTO.Ville = txtVille.Text;
            Mw._controller.CreatePersonne(persoDTO);
            Mw.dtg.ItemsSource = Mw._controller.GetAllPersonnes();
            this.Close();
        }

        private void ModifierPersonne()
        {
            PersonnesDTO perso = new PersonnesDTO();
            perso.Nom = txtNom.Text;
            perso.Prenom = txtPrenom.Text;
            perso.CodePostal = Int32.Parse(txtCodePostal.Text);
            perso.Adresse = txtAdresse.Text;
            perso.Ville = txtVille.Text;
            Mw._controller.UpdatePersonne(Id, perso);
            Mw.dtg.Items.Refresh();
            this.Close();
        }

        private void SupprimerPersonne()
        {
            Mw._controller.GetPersonneById(Id);
            Mw._controller.DeletePersonne(Id);
            Mw.dtg.ItemsSource = Mw._controller.GetAllPersonnes();
            this.Close();
        }
    }
}
