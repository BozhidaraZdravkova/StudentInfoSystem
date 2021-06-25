using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
   public class MainFormVM:MainWindow
    {
        public Student Stud
        {
            get { return Stud; }
            set
            {
                if (Stud != null)
                {
                    Active();
                    GetStudent(Stud.number);
                }
                else
                {
                    Clear();
                    InActive();
                }
            }
        }

    }
}
