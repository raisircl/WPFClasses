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
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;

namespace WpfIntroApp
{
    /// <summary>
    /// Interaction logic for DialogBoxesWindow.xaml
    /// </summary>
    public partial class DialogBoxesWindow : Window
    {
        public DialogBoxesWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "No-Document";
            ofd.DefaultExt = ".txt";
            ofd.Filter = "All Files(.*)|*.*|Text Files(*.txt)|*.txt|Word Documents(*.doc)|*.doc";
            if(ofd.ShowDialog()==true)
            {
                //lblfilename.Content= ofd.FileName;
                lblfilename.Content = File.ReadAllText(ofd.FileName);

            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Untitled";
            sfd.DefaultExt = ".txt";
            sfd.Filter = "All Files(.*)|*.*|Text Files(*.txt)|*.txt|Word Documents(*.doc)|*.doc";
            if (sfd.ShowDialog()==true)
            {
                File.WriteAllText(sfd.FileName, lblfilename.Content.ToString());

                
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.PageRangeSelection = PageRangeSelection.AllPages;
            pd.UserPageRangeEnabled = true;
            pd.ShowDialog();
        }

        private void btnWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new SumWindow();

            window.Owner = this;
            window.Show();
        }
    }
}
