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
using LiveCharts.Wpf;

namespace wpf_exam
{
    /// <summary>
    /// Interaction logic for Diagram.xaml
    /// </summary>
    public partial class Diagram : Window
    {
        public Diagram()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2021",
                    Values = new ChartValues<double> { 390, 530, 639, 750,433,820 }
                },
                new ColumnSeries
                { 
                Title = "2022",
                Values = new ChartValues<double> { 121, 560, 422,233,567, 722 }
                },
                new ColumnSeries
                {
                Title = "2023",
                Values = new ChartValues<double> { 900 }
                }

            };

            

          

            Labels = new[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь" };
           

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }

}

