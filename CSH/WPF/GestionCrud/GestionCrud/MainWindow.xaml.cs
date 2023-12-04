using Grpc.Core;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

namespace GestionCrud
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

        public DataTable jsonDataDisplay()
        {
            StreamReader sr = new StreamReader(Server.MapPath("./Json/produit.json"));
            string json = sr.ReadToEnd();
            dynamic table = JsonConvert.DeserializeObject(json);
            DataTable dt = new DataTable();
            dt.Columns.Add("LibelleProduit",typeof(string));
            dt.Columns.Add("Description",typeof(string));
            dt.Columns.Add("Categorie",typeof(string));
            dt.Columns.Add("Stock",typeof(string));
            dt.Columns.Add("Prix",typeof(int));

            foreach (var row in table.value.data)
            {
                dt.Rows.Add(row.LibelleProduit, row.Description,row.Categorie,row.Stock,row.Prix);
            }
            return dt;
        }
    }
}
