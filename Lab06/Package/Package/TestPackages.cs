using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    class TestPackages
    {
        static void Main(string[] args)
        {
            Package regularPackage = new Package("Peter Anderson", "123 Main St, Ashville, NC 27111", "Mary Brown", "456 Broad St, Benson, NC 27222", 14, 0.5M);
            Console.WriteLine("\nRegular Package: ");
            Console.WriteLine("  Sender's Name: {0}", regularPackage.SenderName);
            Console.WriteLine("  Sender's Address: {0}", regularPackage.SenderAddress);
            Console.WriteLine("  Recipient's Name: {0}", regularPackage.RecipName);
            Console.WriteLine("  Recipient's Address: {0}", regularPackage.RecipAddress);
            Console.WriteLine("  Weight: {0}", regularPackage.Weight);
            Console.WriteLine("  Cost Per Ounce: {0:C}", regularPackage.CostPerOunce);
            Console.WriteLine("  Shipping Cost: {0:C}", regularPackage.CalculateCost());

            TwoDayPackage twoDayPackage = new TwoDayPackage("Peter Anderson", "123 Main St, Ashville, NC 27111", "Mary Brown", "456 Broad St, Benson, NC 27222", 14, 0.5M, 4M);
            Console.WriteLine("\nTwo-Day Package: ");
            Console.WriteLine("  Sender's Name: {0}", twoDayPackage.SenderName);
            Console.WriteLine("  Sender's Address: {0}", twoDayPackage.SenderAddress);
            Console.WriteLine("  Recipient's Name: {0}", twoDayPackage.RecipName);
            Console.WriteLine("  Recipient's Address: {0}", twoDayPackage.RecipAddress);
            Console.WriteLine("  Weight: {0}", twoDayPackage.Weight);
            Console.WriteLine("  Cost Per Ounce: {0:C}", twoDayPackage.CostPerOunce);
            Console.WriteLine("  Flat Fee: {0:C}", twoDayPackage.FlatFee);
            Console.WriteLine("  Shipping Cost: {0:C}", twoDayPackage.CalculateCost());

            OvernightPackage overnightPackage = new OvernightPackage("Peter Anderson", "123 Main St, Ashville, NC 27111", "Mary Brown", "456 Broad St, Benson, NC 27222", 14, 0.5M, 0.8M);
            Console.WriteLine("\nOvernight Package: ");
            Console.WriteLine("  Sender's Name: {0}", overnightPackage.SenderName);
            Console.WriteLine("  Sender's Address: {0}", overnightPackage.SenderAddress);
            Console.WriteLine("  Recipient's Name: {0}", overnightPackage.RecipName);
            Console.WriteLine("  Recipient's Address: {0}", overnightPackage.RecipAddress);
            Console.WriteLine("  Weight: {0}", overnightPackage.Weight);
            Console.WriteLine("  Cost Per Ounce: {0:C}", overnightPackage.CostPerOunce);
            Console.WriteLine("  Additional Cost Per Ounce: {0:C}", overnightPackage.AddFeePerOunce);
            Console.WriteLine("  Shipping Cost: {0:C}", overnightPackage.CalculateCost());

        }
    }
}
