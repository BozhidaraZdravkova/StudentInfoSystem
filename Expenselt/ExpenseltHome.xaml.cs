using System;

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
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseltHome.xaml
    /// </summary>
    /// 
    public partial class ExpenseltHome : Window, INotifyPropertyChanged

    {
        public ExpenseltHome()
        {
            InitializeComponent();
            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();

        }
        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }

            set { lastChecked = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            expenseReport.Show();
            
        }
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            LastChecked = DateTime.Now;
            if (PropertyChanged != null)
                PropertyChanged(this,  new PropertyChangedEventArgs("LastChecked"));
            PersonsChecked.Add((peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value);
        }
        public ObservableCollection<string> PersonsChecked { get; set; }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

   
}
