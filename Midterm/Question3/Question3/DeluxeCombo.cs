using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class DeluxeCombo : RegularCombo
    {
        public string appetizer;

        public void ChooseAppetizer()
        {
            Console.Write("Enter 1 for Spring Roll [$1.25] or 2 for Chicken Wing [$1.50]: ");
            int app = int.Parse(Console.ReadLine());

            if (app == 1)
            {
                appetizer = "Spring Roll";
                total += 1.25m;
            }
            else
            {
                appetizer = "Chicken Wing";
                total += 1.50m;
            }
        }

        public override void DisplayOrder()
        {
            orderNum = counter++;
            Console.WriteLine($"\nOrder Number: {orderNum}\n Appetizer: {appetizer}\n Soup: {soup}\n Main Dish: {dish}\n Total: ${total}\n");

        }
    }
}