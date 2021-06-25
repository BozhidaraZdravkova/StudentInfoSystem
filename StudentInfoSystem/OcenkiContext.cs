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
    class OcenkiContext: DbContext
    {
        public OcenkiContext() : base(Properties.Settings.Default.DbConnect)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Ocenki> Ocenkis { get; set; }

    }
}
