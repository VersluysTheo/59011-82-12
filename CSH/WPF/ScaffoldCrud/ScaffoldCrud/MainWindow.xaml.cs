﻿using ScaffoldCrud.Controllers;
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
        private PersonnesDbContext _context;
        private PersonnesController _controller;
        public MainWindow()
        {
            InitializeComponent();
            _context = new PersonnesDbContext();
            _controller = new PersonnesController(_context);
            dtg.ItemsSource = _controller.GetAllPersonnes();
        }
    }
}
