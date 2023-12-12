using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScaffoldCrud.Controllers;
using ScaffoldCrud.Models.Data;
using ScaffoldCrud.Models.Services;
using ScaffoldCrud.Views;
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

namespace ScaffoldCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonnesDbContext _context;
        public PersonnesController _controller;
        public MainWindow()
        {
            InitializeComponent();
            _context = new PersonnesDbContext();
            _controller = new PersonnesController(_context);
            dtg.ItemsSource = _controller.GetAllPersonnes();
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {
            Personne item;
            if (((Button)sender).Name == "btnAdd")
            {
                item = new Personne();
            }
            else
            {
                item = (Personne)dtg.SelectedItem;
            }
            Window w = new SecondWindow(item,this, Convert.ToString(((Button)sender).Content));
            w.ShowDialog();
        }
        private void Row_DoubleClick(object sender, EventArgs e)
        {
            Personne item = (Personne)((DataGridRow)sender).Item;

            Window w = new SecondWindow(item,this, Convert.ToString(((Button)sender).Content));
            w.ShowDialog();
        }

            private void Dtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;
        }
    }
}
