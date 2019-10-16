using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightTest
{
    public class HeightTest
    {
        static void Main(string[] args)
        {
            Height h1 = new Height(5, 7);
            Console.WriteLine($"h1: {h1.Foot} ft. {h1.Inch} inc.");

            Height h2 = new Height(5);
            Console.WriteLine($"h2: {h2.Foot} ft. {h2.Inch} in.");

            Height h3 = new Height();
            Console.WriteLine($"h3: {h3.Foot} ft. {h3.Inch} in.");

            Height h4 = new Height(h1);
            Console.WriteLine($"h4: {h4.Foot} ft. {h4.Inch} in.");

            try
            {
                Height h5 = new Height(-5, 7);
                Console.WriteLine($"h5: {h5.Foot} ft. {h5.Inch} in.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while initializing h5: ");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Height h6 = new Height(5, -7);
                Console.WriteLine($"h6: {h6.Foot} ft. {h6.Inch} in.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while initializing h6: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
