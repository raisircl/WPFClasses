using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppDataBinding
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string title = "Command Line Arguments is Missing";
            WindowStaticAndDynamicResource window = new WindowStaticAndDynamicResource();
            if(e.Args.Length>0)
            {
                title = e.Args[0];
            }
            window.Title = title;
            window.Show();
        }
    }
}
