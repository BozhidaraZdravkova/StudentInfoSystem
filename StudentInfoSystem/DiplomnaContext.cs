using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
using UserLogin.Models;


namespace StudentInfoSystem
{
    class DiplomnaContext : DbContext
    {
        public DiplomnaContext() : base(Properties.Settings.Default.DbConnect)
        {
        }
        public DbSet<Diplomna> Diplomnas { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Ocenki> Ocenkis { get; set; }

    }
}
