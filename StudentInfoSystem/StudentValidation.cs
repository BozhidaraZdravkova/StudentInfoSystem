using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Models;
namespace StudentInfoSystem
{
   public class StudentValidation
    {
        public  Student GetStudentDataByUser(Users user1) {
            Student student = new Student();
            {
                if (user1.facNumber == 0 || user1.facNumber != student.number)
            
                Console.WriteLine("Incorrect number");
            }
            return student;

        }

    }
}
