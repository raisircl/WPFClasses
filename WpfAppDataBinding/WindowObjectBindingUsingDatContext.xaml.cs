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

namespace WpfAppDataBinding
{
    /// <summary>
    /// Interaction logic for WindowObjectBindingUsingDatContext.xaml
    /// </summary>
    public partial class WindowObjectBindingUsingDatContext : Window
    {
        Person _person;
        public WindowObjectBindingUsingDatContext()
        {
            _person = new Person() { PName = "Amit", Job = "Manager", Sal = 25000 };
            this.DataContext = _person;

            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {_person.PName}, Your Job is {_person.Job} and your sal is {_person.Sal}");
        }
    }
}
