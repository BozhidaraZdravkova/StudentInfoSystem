using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Ocenki
    {
        public int studId { get; set; }
        public DateTime? date { get; set; }
        public string name { get; set; }
        public string ocenka { get; set; }

        public Ocenki()
        {

        }
        public Ocenki(string n, string o)
        {
            date = DateTime.Now;
            name = n;
            ocenka = o;
        }
        public DbSet<Ocenki> Ocenkis { get; set; }
        
    }
}
