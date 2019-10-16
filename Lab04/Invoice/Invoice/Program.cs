using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array of Invoice objects
            var invoices = new[] 
            {
                new Invoice("83", "Electric sander", 7, 57.98M),
                new Invoice("24", "Power saw", 18, 99.99M),
                new Invoice("7", "Sledge hammer", 11, 21.50M),
                new Invoice("77", "Hammer", 76, 11.99M),
                new Invoice("39", "Lawn mower", 3, 79.50M),
                new Invoice("68", "Screwdriver", 106, 6.99M),
                new Invoice("56", "Jig saw", 21, 11.00M),
                new Invoice("3", "Wrench", 34, 7.50M)
            };

            // Use LINQ to sort the Invoice objects by PartDescription.
            var partDescriptionSorted =
                from a in invoices
                orderby a.PartDescription
                select a;

            Console.WriteLine("Invoices sorted by part description: ");
            foreach (var element in partDescriptionSorted)
            {
                Console.WriteLine(element);
            }

            // Use LINQ to sort the Invoice objects by UnitPrice.
            var unitPriceSorted =
                from b in invoices
                orderby b.UnitPrice
                select b;

            Console.WriteLine("\nInvoices sorted by unit price: ");
            foreach (var element in unitPriceSorted)
            {
                Console.WriteLine(element);
            }

            // Use LINQ to select the PartDescription and Quantity and sort the results by Quantity.
            var quantitySorted =
                from c in invoices
                orderby c.Quantity
                select new { c.PartDescription, c.Quantity };

            Console.WriteLine("\nPart description and quantity sorted by quantity: ");
            foreach (var element in quantitySorted)
            {
                Console.WriteLine(element);
            }

            // Use LINQ to select from each invoice the PartDescription and the invoice total amount. 
            // The GetInvoiceAmount method returns the total amount of invoice. Order the results by invoice total amount. 
            // Use let in the LINQ query to store invoice total amount in a new variable. 
            var invoiceTotal =
                from d in invoices
                let total = d.GetInvoiceAmount()
                orderby total
                select new { d.PartDescription, total };

            Console.WriteLine("\nPart description and invoice total sorted by invoice total: ");
            foreach (var element in invoiceTotal)
            {
                Console.WriteLine(element);
            }

            // Using the results of the LINQ query above, select invoices with total amount in the range of $200 to $500.
            var totalRange =
                from e in invoiceTotal
                where (e.total >= 199) && (e.total <= 500)
                select e;

            Console.WriteLine("\nPart description and invoice total, total between $200 and $500: ");
            foreach (var element in totalRange)
            {
                Console.WriteLine(element);
            }

        }
    }
}
