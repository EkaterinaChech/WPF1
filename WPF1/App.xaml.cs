using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Diagnostics;
using System.Windows.Threading;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
<<<<<<< Updated upstream
        
=======
        private static string Theme = "Theme";

>>>>>>> Stashed changes
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.Message);
            e.Handled = true;
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
<<<<<<< Updated upstream
=======
            StreamReader reader = File.OpenText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + "\\Properties\\launchSettings.json");
            
            JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
            string theme = (string)o[Theme];
            //Resources = new ResourceDictionary() { Source = new Uri($"\\Resources\\{theme}Theme.xaml", UriKind.Relative) };
            Current.Resources.MergedDictionaries.Add(
                LoadComponent(new Uri($"\\Resources\\{theme}Theme.xaml", UriKind.Relative)) as ResourceDictionary);

>>>>>>> Stashed changes
            new MainWindow().Show();

        }
    }
}
