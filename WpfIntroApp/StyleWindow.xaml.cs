﻿using System;
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
    /// Interaction logic for StyleWindow.xaml
    /// </summary>
    public partial class StyleWindow : Window
    {
       
        public StyleWindow()
        {
            InitializeComponent();
        }
        private PhotoList _photos;
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            _photos = (PhotoList)(Resources["MyPhotos"] as ObjectDataProvider).Data;
            _photos.Path = "E:\\code\\dotn-net\\wpf-projects\\WpfAmitApps\\WpfIntroApp\\images\\";
        }
    }
}
