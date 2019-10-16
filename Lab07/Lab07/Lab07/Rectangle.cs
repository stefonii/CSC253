using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Rectangle : TwoDimShape
    {
        // two private instance variables length and width
        private int length;
        private int width;

        // public properties 
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        // Constructor should take the length and width of the rectangle as arguments.
        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            Console.WriteLine("It is a rectangle.");
            Console.Write($"Length = {Length}   Width = {Width}   ");
            return Length * Width;
        }

    }
}
