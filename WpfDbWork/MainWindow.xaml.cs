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
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace WpfDbWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();
        SqlDataReader dr;
        ObservableCollection<Brand> brands = new ObservableCollection<Brand>();
        public MainWindow()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=BikeStores;Integrated Security=True";
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comm.CommandText = "select * from [production].brands";
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            conn.Open();
            dr=comm.ExecuteReader();
            while(dr.Read())
            {
                brands.Add(new Brand() { BrandId = Convert.ToInt32(dr["brand_id"]), BrandName = dr["brand_name"].ToString()});
            }
            conn.Close();
            lstBrands.ItemsSource=brands;
        }
    }
    class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
