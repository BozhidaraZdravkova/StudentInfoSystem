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
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        
        public MainWindow()
        {
            InitializeComponent();
            FillStudStatusChoices();
            this.DataContext = this;
            //Clear();
            //GetStudent();
            //InActive();
            //Active();

        }
        public List<string> StudStatusChoices { get; set; }
        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr
 FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // textBox1.Text = string.Empty;

            
        }

       

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }


        public void GetStudent(int number)
        {
            StudentData Student4 = new StudentData();
            foreach (Student student in Student4.TestStudents)
            {
                if (student.number == number)
                {
                    textBox1.Text = student.name;
                    textBox2.Text = student.secondName;
                    textBox3.Text = student.thirdName;
                    textBox8.Text = student.faculty;
                    textBox4.Text = student.spec;
                    textBox5.Text = student.stepen;
                    textBox6.SelectedItem = student.status;
                    textBox7.Text = student.number.ToString();
                    textBox9.Text = student.kurs;
                    textBox10.Text = student.potok;
                    textBox11.Text = student.grupa;
                }
            }

        }
        public void InActive()
        {
            

            foreach (Control ctrl in gr.Children)
            {
                if (ctrl is TextBox)
                {
                    ctrl.IsEnabled = false;
                }

            }
        }
        public void Active()
        {
            
            foreach (Control ctrl in gr.Children)
            {
                if(ctrl is TextBox)
                {
                    ctrl.IsEnabled = true;
                }
            }

        }
        public void Clear()
        {
           

            foreach (Control ctrl in gr.Children)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
        }


        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StudentData cntx = new StudentData();
            cntx.TestStudentsIfEmpty();
           // MessageBox.Show(cntx.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Diplomna dp = new Diplomna();
            dp.Show();
        }
    }
}
