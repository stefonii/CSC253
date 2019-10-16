using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Large
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array to store 10 integers
            int[] array;
            array = new int[10];

            // populate array with random integers in the range of 1 to 99, inclusive
            Random randomNumbers = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1 + randomNumbers.Next(99);
            }
            Console.Write("Array: ");

            // display array
            foreach (var item in array)
            {
                Console.Write(item.ToString() + ", ");
            }

            // call largest function and pass array as an argument
            Console.WriteLine($"\nLargest number: {Largest(array)}");
        }

        static int Largest(int[] array)
        {
            var max = array[0];

            // loop through grades array
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
