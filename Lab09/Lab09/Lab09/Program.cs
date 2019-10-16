// C# Program that calculate factorial. The user enters a positive integer n. The program will calculate and display n!. 
// Program should be able to handle three types of exceptiopns: FormatException, NegativeNumberException, & OverflowException.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determines whether to keep looping.
            var continueLoop = true;

            do
            {
                try
                {
                    // Retrieve user input.
                    Console.Write("Enter a non-negative integer: ");
                    int num = int.Parse(Console.ReadLine());

                    int result = factorial(num);
                    Console.WriteLine($"{num}! = {result}");

                    continueLoop = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number format. Please try again.\n");
                    }
                    catch (NegativeNumberException negativeNumberException)
                    {
                        Console.WriteLine($"{negativeNumberException.Message}");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Input value too large. Please try again.\n");
                    }
                } 
             while (continueLoop);
        }

        // Calculates factorial.
        public static int factorial(int value)
        {
            // if statement to catch negative numbers/integers. 
            if (value < 1)
            {
                throw new NegativeNumberException("Factorial of negative integer not permitted. Please try again.\n");
            }
            else
            {
                // checked block to catch overflow.
                checked
                {
                    int f = value;

                    for (int i = value - 1; i >= 1; i--)
                    {
                        f *= i;
                    }
                    return f;
                }
            }
        }
    }
}
