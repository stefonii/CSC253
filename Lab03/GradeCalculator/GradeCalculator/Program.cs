using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two arrays to store lab and quiz scores
            int[] lab = new int[3];
            int[] quiz = new int[3];

            // use two loops to get these scores from user
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.Write($"Enter Lab {i + 1} score: ");
                lab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (i = 0; i < 3; i++)
            {
                Console.Write($"Enter Quiz {i + 1} score: ");
                quiz[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // tell the user the default weights for labs and quizzes
            // ask user which weights they want to use
            Console.Write("The default weights for course grade are 50% labs and 50% quizzes. Enter C to change the weights or D to use default weights: ");
            string weights = Console.ReadLine();

            Console.WriteLine("\n");

            // call GradeCalculator function and pass the two score arrays, lab weight, and test weight as four argument
            if (weights == "d")
            {
                GradeCalculator(lab, quiz);
            } else if (weights == "c")
            {
                Console.Write("Enter lab percentage (without the % sign): ");
                int lWeight = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter quiz percentage (without the % sign): ");
                int qWeight = Convert.ToInt32(Console.ReadLine());

                GradeCalculator(lab, quiz, lWeight, qWeight);
            }
        }

        // four paramters: lab score array, test score array, lab weight and quiz weight. Lab and quiz weight are optional parameters
        static void GradeCalculator(int[] labScore, int[] quizScore, int labWeight = 50, int quizWeight = 50)
        {
            double labAvg;
            double quizAvg;
            double grades;
            double labTotal = 0;
            double quizTotal = 0;
            double lab;
            double quiz;
            labWeight = labWeight / 100;
            quizWeight = quizWeight / 100;

            // calculate and display average lab score
            foreach (int number in labScore)
            {
                labTotal += number;
            }
            labAvg = labTotal / labScore.Length;
            Console.WriteLine($"\nLab average: {labAvg}");

            // calculate average quiz score
            foreach (int item in quizScore)
            {
                quizTotal += item;
            }
            quizAvg = quizTotal / quizScore.Length;
            Console.WriteLine($"Quiz average: {quizAvg}");

            // use average lab with lab weight and average quiz score with quiz weight to calculate course grade
            lab = labAvg * labWeight;
            quiz = quizAvg * quizWeight;
            grades = lab + quiz;

            Console.WriteLine($"Course grade: {grades}");
        }
    }
}
