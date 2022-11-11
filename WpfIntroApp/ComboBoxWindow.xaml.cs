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
    /// Interaction logic for ComboBoxWindow.xaml
    /// </summary>
    public partial class ComboBoxWindow : Window
    {
        public ComboBoxWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool x = false;
           
            if (!string.IsNullOrEmpty(txtCourse.Text))
            {
                foreach(var item in cmbCourses.Items)
                {
                    var cmbitm=(ComboBoxItem)item;
                    if(cmbitm.Content.ToString()==txtCourse.Text)
                    {
                        x = true;
                    }
                }
                if(x)
                {
                    MessageBox.Show("Item Exist");
                }
                else
                {
                    ComboBoxItem newitm = new ComboBoxItem();
                    newitm.Content = txtCourse.Text;
                    cmbCourses.Items.Add(newitm);
                }
            }
            else
            {
                MessageBox.Show("Unable Empty");
            }
        }
    }
}
