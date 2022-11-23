using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for SumWindow.xaml
    /// </summary>
    public partial class SumWindow : Window
    {
        public SumWindow()
        {
            InitializeComponent();
        }
        //https://learn.microsoft.com/en-us/dotnet/desktop/wpf/systems/xaml-resources-overview?view=netdesktop-6.0
        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2, r=0;
            if (!string.IsNullOrWhiteSpace(txtn1.Text) && !string.IsNullOrWhiteSpace(txtn2.Text))
            {
                n1 = Convert.ToInt32(txtn1.Text);
                n2 = Convert.ToInt32(txtn2.Text);
                Button btn = (Button)sender;
                string? op = btn.Content.ToString();
                switch (op)
                {
                    case "+":
                        r = n1 + n2;
                        break;
                    case "-":
                        r = n1 - n2;
                        break;
                    case "*":
                        r = n1 * n2;
                        break;
                    case "/":
                        r = n1 / n2;
                        break;
                }
                lblResult.Content = r.ToString();
            }
            else
            {
                MessageBox.Show("Numbers can not empty");
            }
        }

        private void btnMargins_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Margins();

            // Display the dialog box and read the response
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                // User accepted the dialog box
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                // User cancelled the dialog box
                MessageBox.Show("Sorry it didn't work out, we'll try again later.");
            }

        }
    }
}
