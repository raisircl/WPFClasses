using System;
using System.Collections.Generic;
using System.Globalization;
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
        int x = 0;
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

        private void btnGetStates_Click(object sender, RoutedEventArgs e)
        {
            string states="";
            lblStates.Items.Clear();
            foreach(var itm in cmbStates.Items)
            {
                if (itm.GetType() == typeof(CheckBox))
                {
                    CheckBox chk = (CheckBox)itm;
                    if ((bool)chk.IsChecked)
                    {
                        states = states + chk.Content.ToString() + ", ";
                        lblStates.Items.Add(chk.Content.ToString());
                    }
                }
            }

            cmbStates.Items.Add(states);
            cmbStates.SelectedIndex = cmbStates.Items.Count - 1;




        }

        private void cmbStates_DropDownOpened(object sender, EventArgs e)
        {
            if (cmbStates.Items.Count > x)
            {
                cmbStates.SelectedIndex = -1;
                cmbStates.Items.RemoveAt(cmbStates.Items.Count - 1);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            x = cmbStates.Items.Count;
        }
    }
}
