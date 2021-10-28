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
    /// Interaction logic for MinMaxClose.xaml
    /// </summary>
    public partial class MinMaxClose : UserControl
    {
        public MinMaxClose()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(App.Current.MainWindow);
        }

        private void MaximizeClick(object sender, RoutedEventArgs e)
        {
            if (App.Current.MainWindow.WindowState == WindowState.Maximized)
                App.Current.MainWindow.WindowState = WindowState.Normal;
            else
                SystemCommands.MaximizeWindow(App.Current.MainWindow);
        }
    }
}
