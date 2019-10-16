using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    public class Weight
    {
        public int pound;
        public int ounce;

        public Weight(int pound, int ounce)
        {
            this.pound = pound;
            this.ounce = ounce;
        }
    }
    public class WeightTest
    {
        static void Main(string[] args)
        {
            Weight weight1 = new Weight(5, 14);
            Console.WriteLine($"Weight 1: {weight1.pound} lb. {weight1.ounce} oz. ");
        }


    }
}
