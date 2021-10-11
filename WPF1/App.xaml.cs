using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Windows.Threading;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MainWindow window;
        private void StartUp(object sender, StartupEventArgs e)
        {
            window = new MainWindow();
            if (e.Args.Length == 1)
            {
                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            }

            window.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.Message);
            e.Handled = true;
        }
    }
}
