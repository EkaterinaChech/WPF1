using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF1.UserControls.ViewModels.Models;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> Themes { get; set; }

        public MainWindow()
        {
            Themes = GetThemeList();
            InitializeComponent();
            //SettingsBox.ItemsSource = Themes;
        }

        private void DragEvent(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }

            DragMove();
        }

        public List<string> GetThemeList()
        {
            if (Themes != null)
                return Themes;

            Themes = new List<string>();
            var files = Directory.GetFiles(App.ResourcesPATH + "\\Themes");
            List<string> result = new List<string>();
            foreach (var name in files)
            {
                var split = name.Split('\\', '.');
                result.Add(split[split.Length-2]);
            }
            return result;
        }
    }
}