using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for InfographicWindow.xaml
    /// </summary>
    public partial class InfographicWindow : Window
    {
        public InfographicWindow()
        {
            InitializeComponent();

            IList<FinancialChanges> FinCh;

            FinCh = new ObservableCollection<FinancialChanges>
            {
                new FinancialChanges() { MonthName = "Январь"  },
                new FinancialChanges() { MonthName = "Февраль" },
                new FinancialChanges() { MonthName = "Март" },
                new FinancialChanges() { MonthName = "Апрель" },
                new FinancialChanges() { MonthName = "Май" },
                new FinancialChanges() { MonthName = "Июнь" },
                new FinancialChanges() { MonthName = "Июль" },
                new FinancialChanges() { MonthName = "Август" },
                new FinancialChanges() { MonthName = "Сентябрь" },
                new FinancialChanges() { MonthName = "Октябрь" },
                new FinancialChanges() { MonthName = "Ноябрь" },
                new FinancialChanges() { MonthName = "Декабрь" },
                new FinancialChanges() { MonthName = "Итого" }
            };

            this.DataContext = FinCh;
        }

        private void Button_Click_PieChart(object sender, RoutedEventArgs e)
        {
            pieChart pieChart = new pieChart();
            pieChart.ShowDialog();
        }

        private void Button_Click_Daigramm(object sender, RoutedEventArgs e)
        {
            Diagram diagram = new Diagram();
            diagram.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}

