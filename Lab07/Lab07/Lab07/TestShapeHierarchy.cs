using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class TestShapeHierarchy
    {
        static void Main(string[] args)
        {
            TwoDimShape[] myShapes = new TwoDimShape[3];
            myShapes[0] = new Rectangle(10, 5);
            myShapes[1] = new Triangle(12, 6);
            myShapes[2] = new Circle(8);

            foreach (TwoDimShape tds in myShapes)
            {
                ProcessShape(tds);
                Console.WriteLine("");
            }
        }
        // static method processShape
        public static void ProcessShape(TwoDimShape obj)
        {
            Console.Write($"Area = {obj.Area()}");
        }
    }
}
