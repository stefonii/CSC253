using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class RegularCombo
    {
        public static int counter = 101;
        public decimal total = 0;
        public int orderNum;
        public string soup;
        public string dish;
        
        // Method has no parameter and no return value. It displays main dish choices and let the user choose one.
        public void ChooseMainDish()
        {
            Console.Write("Enter 1 for Sweet and Sour Pork [$7], 2 for Sesame Chicken [$8], or 3 for Shrimp Fried Rice [$9]: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                dish = "Sweet and Sour Pork";
                total += 7;

            } else if (a == 2)
            {
                dish = "Sesame Chicken";
                total += 8;
            } else
            {
                dish = "Shrimp Fried Rice";
                total += 9;
            }
        }

        // Method has no parameter and no return value. It displays soup choices and let the user choose one. 
        public void ChooseSoup()
        {
            Console.Write("Enter 1 for Egg Drop Soup [$1.25] or 2 for Wanton Soup [$1.50]: ");
            int soupChoice = int.Parse(Console.ReadLine());
            if (soupChoice == 1)
            {
                soup = "Egg Drop Soup";
                total += 1.25m;
            } else
            {
                soup = "Wanton Soup";
                total += 1.50m;
            }
        }


        // Method has no parameter and no return value. It displays an order number, soup, and main dish chosen by the customer, and total price.
        public virtual void DisplayOrder()
        {
            orderNum = counter++;
            Console.WriteLine($"\nOrder Number: {orderNum}\n Soup: {soup}\n Main Dish: {dish}\n Total: ${total}\n");
        }
    }
}
