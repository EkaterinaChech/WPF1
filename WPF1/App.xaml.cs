using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Text.Json;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string Theme = "Theme";
        
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.Message);
            e.Handled = true;
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            //string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "abc.txt");
            using (StreamReader reader = File.OpenText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + "\\Properties\\launchSettings.json"))
            {
                JObject o = (JObject) JToken.ReadFrom(new JsonTextReader(reader));
                string theme = (string) o[Theme];
                Resources = new ResourceDictionary()
                    {Source = new Uri($"\\Resources\\{theme}Theme.xaml", UriKind.Relative)};
            }

            new MainWindow().Show();

        }
    }
}
