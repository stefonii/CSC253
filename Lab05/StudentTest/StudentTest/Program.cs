using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Amy Lee");
            Student student2 = new Student("John Williams");
            student1.DisplayInfo();
            student2.DisplayInfo();
        }
    }
}
