using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let user decide the size of 2D array (# of rows & columns)
            Console.Write("How many rows do you want?: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("How many columns do you want?: ");
            int columns = int.Parse(Console.ReadLine());

            // Populate the array with random numbers from 10 to 99, inclusive. 
            Random rand = new Random();
            int[,] original;
            original = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    original[r, c] = rand.Next(10, 100);
                }
            }

            // Display the array.
            Console.WriteLine("\nOriginal array: ");
            for (var row = 0; row < original.GetLength(0); ++row)
            {
                for (var column = 0; column < original.GetLength(1); ++column)
                {
                    Console.Write($"{original[row, column]} ");
                }
                Console.WriteLine();
            }

            // Create a new 2D array, which is the transpose of the original array. 
            int[,] transposeArray;
            transposeArray = new int[columns, rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    transposeArray[x, y] = original[y, x];
                }
            }

            // Display this array.
            Console.WriteLine("\nTranspose: ");
            for (var a = 0; a < transposeArray.GetLength(0); ++a)
            {
                for (var b = 0; b < transposeArray.GetLength(1); ++b)
                {
                    Console.Write($"{transposeArray[a, b]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
