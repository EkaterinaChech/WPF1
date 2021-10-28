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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1.UserControls
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : UserControl
    {
        public List<string> Themes = new List<string> {"Light", "Dark"};
        public SettingsPage()
        {
            InitializeComponent();
        }


        private void ThemeBox_OnSelected(object sender, RoutedEventArgs e)
        {
            string Theme = ThemeBox.SelectedValue.ToString();
            var URI = new Uri($"\\Resources\\{Theme}Theme.xaml",UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(URI) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
