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

namespace wpf_exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    [Obsolete]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Income_Outcome(object sender, RoutedEventArgs e)
        {
            InOut inOut = new InOut();
            inOut.ShowDialog();
        }

        private void Button_Click_Infographics(object sender, RoutedEventArgs e)
        {
            InfographicWindow infwindow = new InfographicWindow();
            infwindow.ShowDialog();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
