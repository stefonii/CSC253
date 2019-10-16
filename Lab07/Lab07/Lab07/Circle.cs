using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Circle : TwoDimShape
    {
        // one private instance variable radius
        private int radius;

        // corresponding public property
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        // Constructor: take the radius of the circle as argument
        public Circle(int r)
        {
            Radius = r;
        }

        public override double Area()
        {
            Console.WriteLine("\nIt is a circle.");
            Console.Write($"Radius = {Radius}   ");
            return Radius * Radius * System.Math.PI;
        }
    }
}
