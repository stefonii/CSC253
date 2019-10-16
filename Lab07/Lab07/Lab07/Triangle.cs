using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Triangle : TwoDimShape
    {
        // two private instance variables base and height
        private int b;
        private int h;

        // corresponding public properties Base and Height
        public int Base
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int Height
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }

        // Constructor: take base and height of triangle as arguments
        public Triangle(int b, int h)
        {
            Base = b;
            Height = h;
        }

        public override double Area()
        {
            Console.WriteLine("\nIt is a triangle.");
            Console.Write($"Base = {Base}   Height = {Height}   ");
            return (Base * Height) / 2;
        }
    }
}
