using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UserLogin;
using UserLogin.Models;
//using Microsoft.EntityFrameworkCore;

namespace StudentInfoSystem
{
  public  class StudentInfoContext : DbContext
    {
        public StudentInfoContext() : base(Properties.Settings.Default.DbConnect)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
       
    }
}

