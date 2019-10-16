using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 2;
            int seats = 0;
            int waiting = 0;

            Console.Write("Enter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 0)
            {
                if (choice == 1)
                {
                    seats++;
                    // make sure there's enough seats
                    if (seats > capacity)
                    {
                        waiting++;
                        seats--;
                        Console.WriteLine("Class already full. Student added to waiting list.");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("One student added.");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");
                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    }
                }
                else if (choice == 2)
                {
                    if (seats <= 0)
                    {
                        Console.Write("Class already empty. Drop is not allowed.\n");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        seats--;
                        Console.Write("One student dropped.\n");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n"); 

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    }
                } else if (choice == 3)
                {
                    Console.Write("Enter new capacity: ");
                    int cap = int.Parse(Console.ReadLine());

                    if (cap < 0)
                    {
                        Console.Write("New capacity cannot be negative.\n");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    } else if (cap < seats)
                    {
                        Console.Write("New capacity cannot be lower than seats taken.\n");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());
                    } else
                    {
                        capacity = cap;
                        Console.Write("Capacity changed.\n");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        int change = 0;
                        while (seats < capacity && waiting > 0)
                        {
                            seats++;
                            waiting--;
                            change++;
                        }
                        Console.WriteLine($"\n{change} waitlisted students added to the class.");
                        Console.Write($"Capacity: {capacity}\t Seat Taken: {seats}\t Waiting List: {waiting}\n");

                        Console.Write("\nEnter 1 to add, 2 to drop, 3 to change capacity, 0 to exit: ");
                        choice = int.Parse(Console.ReadLine());  
                    }
                }
            }
            
        }
    }
}
