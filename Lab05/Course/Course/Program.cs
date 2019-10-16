using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class CourseTest
    {
        static void Main(string[] args)
        {
            Course csc153 = new Course() { CourseName = "Intro C#" , Instructor = "Leung"};
            csc153.DisplayInfo();

            Course csc152 = new Course() { CourseName = "SAS", Instructor = "Orazem" };
            csc152.DisplayInfo();
        }
    }
}
