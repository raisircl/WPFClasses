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
    /// Interaction logic for CodeBehindBindingsSample.xaml
    /// </summary>
    public partial class CodeBehindBindingsSample : Window
    {
        public CodeBehindBindingsSample()
        {
            InitializeComponent();
            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            binding.Mode = BindingMode.OneWay;
            lblValue.SetBinding(TextBlock.TextProperty, binding);


        }
    }
}
