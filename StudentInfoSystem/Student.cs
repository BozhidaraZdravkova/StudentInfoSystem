using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
   public class Student
    { public int StudentId { get; set; }
        public string name { get; set; }
        public string secondName{ get; set; }
        public string thirdName { get; set; }
        public string faculty{ get; set; }
        public string spec{ get; set; }
        public string stepen{ get; set; }
        public string status {get; set; }
        public int number {get; set; }
        public string kurs{ get; set; }
        public string potok{ get; set; }
        public string grupa{ get; set; }
        //public string pass { get; set; }
        public DbSet<Student> Students { get; set; }
      


    }
}
