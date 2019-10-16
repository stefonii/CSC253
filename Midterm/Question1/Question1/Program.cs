using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store 10 integers.
            int numRands = 10;
            Random rand = new Random();
            int[] nums = new int[numRands];

            // Populate this array with random integers in the range of 1 to 9, inclusive. 
            for (int i = 0; i < numRands; i++)
            {
                nums[i] = rand.Next(1, 10);
            }

            Console.Write("Array: ");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Call the Total function and pass the array as an argument.
            Console.WriteLine($"Total: {Total(nums)}");
            // Display the return value. 
        }

        // Total function: receives an array as an arugment. 
        static int Total(int[] nums)
        {
            // If the array has only one element, return that element. 
            if (nums.Length == 1)
            {
                return nums[0];
            }
            else
            {
                int[] first = new int[1];
                for (int i = 0; i < first.Length; i++)
                {
                    first[i] = nums[i];
                }

                int[] second = new int[9];
                for (int i = 0; i < second.Length; i++)
                {
                    second[i] = nums[i + first.Length];
                }

                int result = second.Sum();
                return Total(first) + result; 
            }
        }
    }
}
