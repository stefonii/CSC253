using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a jagged two dimensional array
            int[][] jagged = new int[3][];

            // for each student, ask how many attempts that student has made and input scores
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Student {i + 1 }: \n");

                Console.Write("How many attempts has this student made?: ");
                int num = Convert.ToInt32(Console.ReadLine());

                jagged[i] = new int[num];
                for (int j = 0; j < num; j++)
                {
                    Console.Write("Enter score: ");
                    int score = Convert.ToInt32(Console.ReadLine());

                    jagged[i][j] = score;
                }
                Console.Write("\n");
            }

            // after all scores are entered, display scores and calculate averages 
            // each student separately; display scores of all attempt 
            for (int x = 0; x < jagged.Length; x++)
            {
                if (jagged[x] == null || jagged[x].Length == 0)
                {
                    Console.Write($"Student {x + 1} scores: This student has made no attempt.");
                } else
                {
                    Console.Write($"Student {x + 1} scores: ");
                    for (int y = 0; y < jagged[x].Length; y++)
                    {
                        Console.Write(jagged[x][y] + ", ");
                    }
                    Console.WriteLine();

                    decimal total = 0;
                    foreach (var item in jagged[x])
                    {
                        total += item;
                    }
                    decimal studentAvg = total / jagged[x].Length;
                    Console.Write($"Average: {studentAvg}\n");
                }
            }
 
            // each attempt separately; display scores of all students have made that attempt
            for (int a = 0; a < jagged.Length; a++)
            {
                Console.Write($"Attempt {a + 1} scores: ");

                for (int b = 0; b < jagged[a].Length; b++)
                {
                    Console.Write(jagged[b][a]);
                }
                Console.WriteLine();
            }
        }
    }
}
