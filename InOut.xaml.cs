using Newtonsoft.Json;
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
using System.IO;
using System.ComponentModel;


namespace wpf_exam
{
    /// <summary>
    /// Interaction logic for InOut.xaml
    /// </summary>
    public partial class InOut : Window
    {
        private readonly string path = $"{Environment.CurrentDirectory}\\inOutCl.json";
        private BindingList<InOutCl> inOutCl;
        private jsonSer file;

        
        public InOut()
        {
            InitializeComponent();
            
            inOutCl = new BindingList<InOutCl>();
        
           
        }

        private void InOutCl_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                try
                {
                    file.SaveData(sender);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
                
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            e.NewItem = new InOutCl { Date = DateTime.Now, MoneyChange = 0, Reason = "---" };
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {         
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

            file = new jsonSer(path);

            try
            {
                inOutCl = file.LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Close();
            }
            inoutlist.ItemsSource = inOutCl;
            inOutCl.ListChanged += InOutCl_ListChanged;

        }
    }
}

