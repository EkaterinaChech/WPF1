﻿using System;
using System.Windows;
using System.IO;
using System.Windows.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WPF1
{
    public partial class App : Application
    {
        private static string Theme = "Theme";
        public static string Style;

        public static string LaunchSettingsPATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent +
                                                  "\\Properties\\launchSettings.json";

        public static string ResourcesPATH =
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + "\\Resources";

        public static string CorePATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();

        public static Window MainWindow;

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.Message);
            e.Handled = true;
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            StreamReader reader = File.OpenText(LaunchSettingsPATH);

            JObject o = (JObject) JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
            string theme = (string) o[Theme];
            Style = theme;
            Current.Resources.MergedDictionaries.Add(
                LoadComponent(new Uri($"\\Resources\\Themes\\{theme}.xaml", UriKind.Relative)) as ResourceDictionary);

            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}