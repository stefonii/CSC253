using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1._1
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {

            // ask the user to choose one of three parts.
            Console.Write("Enter 1 for Part A2507, 2 for Part A2714, 3 for Part A2845: ");
            int part = int.Parse(Console.ReadLine());

            // create an invoice object.
            Invoice obj = new Invoice();
            if (part == 1)
            {
                Invoice num1 = new Invoice("A2507", 16.25m);
            } else if (part == 2)
            {
                Invoice num1 = new Invoice("A2714", 24.75m);
            } else if (part == 3)
            {
                Invoice num1 = new Invoice("A2845", 27);
            }
            

            // ask user to enter quantity.
            Console.Write("Enter quantity: ");
            int num = int.Parse(Console.ReadLine());
            obj.Quantity = num;

            // Call DisplayOrder method to display order.
            Console.WriteLine($"Your Order: {obj.DisplayOrder()}");
            

            
        }
    }
}
