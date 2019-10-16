using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today's Lunch Menu: \n Lunch Combo 1: Fried Chicken with Slaw [Price: $4.25] \n Lunch Combo 2: Roast Beef with Mashed Potato [Price: $5.75] \n Lunch Combo 3: Fish and Chips [Price: $5.25] \n Lunch Combo 4: Soup and Salad [Price: $3.75]\n");

            Console.Write("How many people in the group? ");
            int people = int.Parse(Console.ReadLine());

            decimal total = 0;
            int counter = 1;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;

            //processing phase using counter-controlled loop
            while (counter <= people)
            {
                Console.Write($"Choice of customer #{counter} [1/2/3/4]: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    one += 1;
                    total += 4.25m;
                    counter += 1;
                }
                else if (choice == 2)
                {
                    two += 1;
                    total += 5.75m;
                    counter += 1;
                }
                else if (choice == 3)
                {
                    three += 1;
                    total += 5.25m;
                    counter += 1;
                }
                else if (choice == 4)
                {
                    four += 1;
                    total += 3.75m;
                    counter += 1;
                }
                else
                {
                    counter += 1;
                }
            }

            // Order Summary
            Console.Write($"\nOrder Summary: \n Lunch Combo 1: {one}\n Lunch Combo 2: {two}\n Lunch Combo 3: {three}\n Lunch Combo 4: {four}\n");
            Console.WriteLine($"Total Amount Due: ${total}");
        }
    }
}
