using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for Diplomna.xaml
    /// </summary>
    public partial class Diplomna : Window
    {
        public Diplomna()
        {
            InitializeComponent();
        }
        public string tema { get; set; }
        public Diplomna(string t)
        {
            tema = t;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            MessageBox.Show("Записано!");
            txt1.Text = string.Empty;

        }
        public DbSet<Diplomna> Diplomnas { get; set; }
    }
}
