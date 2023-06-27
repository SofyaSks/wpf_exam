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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace wpf_exam
{
    /// <summary>
    /// Interaction logic for pieChart.xaml
    /// </summary>
    public partial class pieChart : Window
    {
        public pieChart() 
        {
            InitializeComponent();


            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Январь",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(10)},
                    DataLabels = false
            
                },
                new PieSeries
                {
                    Title = "Февраль",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(30)},
                    DataLabels = false

                },
                new PieSeries
                {
                    Title = "Март",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(25)},
                    DataLabels = false
            
                },
                new PieSeries
                {
                    Title = "Апрель",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(20)},
                    DataLabels = false

                },
                new PieSeries
                {
                    Title = "Май",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(40)},
                    DataLabels = false

                },
                new PieSeries
                {
                    Title = "Июнь",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(15)},
                    DataLabels = false

                }
            };

            DataContext = this;
           
        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        public SeriesCollection SeriesCollection { get;  set; }

        

    }
}
