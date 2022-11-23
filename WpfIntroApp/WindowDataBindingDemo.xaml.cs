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
using WpfIntroApp.RaiLib;
namespace WpfIntroApp
{
    /// <summary>
    /// Interaction logic for WindowDataBindingDemo.xaml
    /// </summary>
    public partial class WindowDataBindingDemo : Window
    {
        public WindowDataBindingDemo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();
            lstEmp.ItemsSource = emp.GetEmployees();
        }
    }
}
