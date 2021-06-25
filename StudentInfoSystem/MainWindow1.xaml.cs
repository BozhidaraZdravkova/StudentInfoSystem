using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using UserLogin;
using UserLogin.Controllers;
using UserLogin.Models;
using UserLogin.Utiles;
namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();

        }
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                Users usr = new Users();
                Users u = new Users();
                usr = db.Users.Where(s => s.name == u.name).FirstOrDefault();
                foreach (Users user in db.Users)
                {
                    if (txt1.Text.Equals(user.name) && (txt2.Text.Equals(user.pass)) && (user.role == 4))
                    {
                        //MainWindow mainWindow = new MainWindow();
                        StudentData studentData = new StudentData();
                        foreach (Student student in studentData.TestStudents)
                        {
                            if (student.number == user.facNumber)
                            {
                                MainWindow mainWindow = new MainWindow();
                                mainWindow.GetStudent(user.facNumber);
                                mainWindow.Show();
                                this.Close();
                            }
                        }

                    }
                    else {
                        continue;
                         }
                }
            }
                
            /*Users usr = new Users();
            StudentInfoContext context = new StudentInfoContext();
            
            Student u = (from st in context.Students where st.name == usr.name  && st.number == 4 select st).First();
            if(u != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.GetStudent(u.number);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }*/
            /* Users user = null;
             Validator loginValidation = new Validator();

              if (loginValidation.ValidateUserInput(ref user) && user.role == 4)
              {

                  MainWindow mainWindow = new MainWindow();
                  mainWindow.GetStudent(user.facNumber);
                  mainWindow.Show();
                  this.Close();


              }
              else 
              {
                  MessageBox.Show("Error");
              }
              */




            /*  using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
              {

                  Users u = new Users();
                 foreach (Users user in db.Users.Where(s => s.name == u.name))
                 {
                     if (txt1.Text.Equals(user.name) && (txt2.Text.Equals(user.pass)) && (user.role == 4))
                     {
                         //MainWindow mainWindow = new MainWindow();
                         StudentData studentData = new StudentData();
                         foreach (Student student in studentData.TestStudents)
                         {
                             if (student.number == user.facNumber)
                             {
                                 MainWindow mainWindow = new MainWindow();
                                 mainWindow.GetStudent(user.facNumber);
                                 mainWindow.Show();
                                 this.Close();
                             }
                         }

                     }
                     else { continue; }
                 }

             }*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
    {


    }
}
}
