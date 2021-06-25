using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
using UserLogin.Models;
namespace StudentInfoSystem
{
    public class StudentData
    {

        private List<Student> testStudents = new List<Student>();

        public  List<Student> TestStudents
        {
            get {
                Add();
                return testStudents; }
            set { testStudents = value; }
        }
       public void  Add() {
            Student student1 = new Student()

            { name = "Bozhidara",
                secondName = "Lubomirova",
                thirdName = "Zdravkova",
                faculty = "FKSU",
                spec = "KSI",
                stepen = "Bakalavyr",
                status = "Zaveril",
                number = 121217112,
                kurs = "3",
                potok = "9",
                grupa = "40"
                

            };
            testStudents.Add(student1);
           

        }
       
        //StudentInfoContext context = new StudentInfoContext();
        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> quertyStudents = context.Students;
            int? countStudents = quertyStudents.Count();

            if (quertyStudents == null)
            {
                return true;
            }
            else { return false; }
            
                 
        }
        Users user1 = new Users();
        StudentInfoContext context = new StudentInfoContext();
       

        public void CopyTestStudents()
        {
           // StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
            if (TestStudentsIfEmpty())
                CopyTestStudents();


           

        }
        public void CopyTestUsers()
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                Users u = new Users();
                user1 = db.Users.Where(s => s.name == u.name).FirstOrDefault();

                foreach (Users users in db.Users)
                {
                    context.Users.Add(users);
                }
                
                //UserContext context = new UserContext();
                StudentData studentdata = new StudentData();
                /*foreach (User user in UserData.TestUsers)
                {
                    context.Users.Add(user);
                }*/
                context.SaveChanges();
            }
        }

        public  Student IsThereStudent()
        {
            Users user1 = new Users();
            StudentInfoContext context = new StudentInfoContext();
            

                Student result = (from st in context.Students where st.number == user1.facNumber select st).First();
            

                return result;
            
        }
    }
}
