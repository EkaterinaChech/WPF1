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
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WPF1.UserControls.ViewModels.Views
{
    /// <summary>
    /// Interaction logic for ViewPage.xaml
    /// </summary>
    public partial class ViewPage : UserControl
    {
        private string Age = "Age";
        private string Male = "males";
        private string Female = "females";

        public ViewPage()
        {
            InitializeComponent();
            PointLabel = chartPoint => $"{chartPoint.SeriesView.Title}\n{chartPoint.Participation:p}";
            DataContext = this;
            var reader = new StreamReader(App.CorePATH + "\\Data\\AgesData.json");
            JToken o = JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
            Dictionary<string, long> AgeGroup = new Dictionary<string, long>();
            long tempValue = 0;
            foreach (var age in o)
            {
                if ((int) age[Age] % 10 != 0|| (int)age[Age]==0)
                {
                    tempValue += (long) age[Male];
                    tempValue += (long) age[Female];
                    continue;
                }

                int ageLocal = (int) age[Age];
                //AgeGroup.Add($"{(ageLocal - 10)}-{ageLocal}", tempValue)
                pipChart.Series.Add((new PieSeries
                {
                    DataLabels =true, LabelPoint = PointLabel, Title = $"{ageLocal - 10}-{ageLocal}",
                    Values = new ChartValues<long> {tempValue}
                }));
                tempValue = 0;
            }


            /* StreamReader reader = File.OpenText(LaunchSettingsPATH);

            JObject o = (JObject) JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();
            string theme = (string) o[Theme];
            Style = theme;
            Current.Resources.MergedDictionaries.Add(
                LoadComponent(new Uri($"\\Resources\\Themes\\{theme}.xaml", UriKind.Relative)) as ResourceDictionary);*/

            /* <!--<wpf:PieSeries Title="Maria" 
                               DataLabels="True" 
                               LabelPoint="{Binding PointLabel}"
                               Values="3"/>
                <wpf:PieSeries Title="Charles" 
                               DataLabels="True" 
                               LabelPoint="{Binding PointLabel}" 
                               Values="4"/>
                <wpf:PieSeries Title="Frida" 
                               DataLabels="True" 
                               LabelPoint="{Binding PointLabel}" 
                               Values="6"/>
                <wpf:PieSeries Title="Frederic" 
                               DataLabels="True" 
                               LabelPoint="{Binding PointLabel}" 
                               Values="2"/>-->*/
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void pipChart_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart) chartPoint.ChartView;

            //clear selected slice
            foreach (PieSeries series in chart.Series)
            {
                series.PushOut = 0;

                var selectedSeries = (PieSeries) chartPoint.SeriesView;
                selectedSeries.PushOut = 8;
            }
        }
    }
}