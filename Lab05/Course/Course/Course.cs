using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course
    {
        // Two self-implemented properties CourseName and Instructor.
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        // Public accessible method DisplayInfo to display data stored in these two properties. 
        public void DisplayInfo()
        {
            Console.WriteLine($"Course: {CourseName}\t Instructor: {Instructor}");
        }
    }
}
