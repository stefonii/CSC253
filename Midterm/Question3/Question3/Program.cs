using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.Write("Enter 1 for regular combo, 2 for deluxe combo or 3 to exit: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    RegularCombo myOrder = new RegularCombo();
                    myOrder.ChooseSoup();
                    myOrder.ChooseMainDish();
                    myOrder.DisplayOrder();
                }
                else if (choice == 2)
                {
                    DeluxeCombo myOrder = new DeluxeCombo();
                    myOrder.ChooseAppetizer();
                    myOrder.ChooseSoup();
                    myOrder.ChooseMainDish();
                    myOrder.DisplayOrder();
                }
            }

        }
    }
}
