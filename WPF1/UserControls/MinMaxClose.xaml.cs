using System.Windows;
using System.Windows.Controls;

namespace WPF1.UserControls
{
    /// <summary>
    /// Interaction logic for MinMaxClose.xaml
    /// </summary>
    public partial class MinMaxClose : UserControl
    {
        public MinMaxClose() => InitializeComponent();

        private void ExitClick(object sender, RoutedEventArgs e) => App.Current.Shutdown(0);

        private void MinimizeClick(object sender, RoutedEventArgs e) =>
            SystemCommands.MinimizeWindow(App.Current.MainWindow);

        private void MaximizeClick(object sender, RoutedEventArgs e)
        {
            if (App.Current.MainWindow.WindowState == WindowState.Maximized)
                App.Current.MainWindow.WindowState = WindowState.Normal;
            else
                SystemCommands.MaximizeWindow(App.Current.MainWindow);
        }
    }
}