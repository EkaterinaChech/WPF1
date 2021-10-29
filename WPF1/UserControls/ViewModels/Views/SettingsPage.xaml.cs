using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1.UserControls
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }


        private void ThemeBox_OnSelected(object sender, RoutedEventArgs e)
        {
            string theme = ThemeBox.SelectedValue.ToString();
            var URI = new Uri($"\\Resources\\{theme}Theme.xaml",UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(URI) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);

            UpdateLaunchSettingsTheme(theme);

        }

        private void UpdateLaunchSettingsTheme(string theme)
        {
            string json = File.ReadAllText(App.LaunchSettingsPATH);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["Theme"] = theme;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(App.LaunchSettingsPATH, output);
        }
    }
}
