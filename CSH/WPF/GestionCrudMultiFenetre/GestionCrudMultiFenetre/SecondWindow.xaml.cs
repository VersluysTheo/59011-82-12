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

namespace GestionCrudMultiFenetre
{
    /// <summary>
    /// Logique d'interaction pour SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////// Event ///////////////////////////////////////////

        private void SecondWindow_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSave.IsEnabled = true;
            btnCancel.IsEnabled = true;
        }

        private void CbxCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnSave.IsEnabled = true;
            btnCancel.IsEnabled = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
