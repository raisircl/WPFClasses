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

namespace WpfIntroApp
{
    /// <summary>
    /// Interaction logic for RadioWindow.xaml
    /// </summary>
    public partial class RadioWindow : Window
    {
        public RadioWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if((bool)rbMale.IsChecked)
            {
                MessageBox.Show("Hello Mr.");
            }
            else
            {
                MessageBox.Show("Hello Miss");
            }
        }

        private void rbRadio_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Content.ToString()=="Male" && (bool)rb.IsChecked)
            {
                MessageBox.Show("Hello Mr.");
            }
            else if (rb.Content.ToString() == "Female" && (bool)rb.IsChecked)
            {
                MessageBox.Show("Hello Miss.");
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if((bool)chkPlaying.IsChecked && (bool)chkStudying.IsChecked)
            {
                MessageBox.Show("Excelent");
            }
            else if((bool)chkPlaying.IsChecked)
            {
                MessageBox.Show("Good");
            }
            else if((bool)chkStudying.IsChecked)
            {
                MessageBox.Show("Very Good");
            }
        }
    }
}
