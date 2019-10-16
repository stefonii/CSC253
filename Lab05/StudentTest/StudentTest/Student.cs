using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class Student
    {
        // Two private instance variables, name and id, to store student's name and ID. 
        private string name;
        private int id;
        private static int counter = 1001;


        // Constructor that takes a string as an argument. String will be stored as the student's name.
        public Student(string name)
        {
            id = counter++;
            this.name = name;
        }

        // DisplayInfo method to display the ID and name of student. 
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}  Name: {name}");
        }
    }
}
