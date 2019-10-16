using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Console application that inserts 30 random integers in the range of 1 to 20 into a List<t> using LINQ.

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create random number generator
            Random randomNumber = new Random();

            // Create a List<t>
            var items = new List<int>();

            // Insert 30 random integer in the range 1 to 20 into a List<t>
            for (var i = 0; i < 30; i++)
            {
                int num = randomNumber.Next(1, 21);
                items.Add(num);
            }

            // Display original list.
            Console.WriteLine("Original list: ");
            foreach (var element in items)
            {
                Console.Write($"{element}  ");
            }

            // Use LINQ to sort the list in ascending order. Display the list.
            var aSort =
                from a in items
                orderby a
                select a;

            Console.WriteLine("\n\nList sorted in ascending order: ");
            foreach (var element in aSort)
            {
                Console.Write($"{element}  ");
            }

            // Use LINQ to sort the list in descending order. Display the list.
            var dSort =
                from b in items
                orderby b descending
                select b;

            Console.WriteLine("\n\nList sorted in descending order: ");
            foreach (var element in dSort)
            {
                Console.Write($"{element}  ");
            }

            // Display the list in ascending order with duplicates removed.
            Console.WriteLine("\n\nList sorted in ascending order with duplicates removed: ");
            foreach (var element in aSort.Distinct())
            {
                Console.Write($"{element}  ");
            }
        }
    }
}
