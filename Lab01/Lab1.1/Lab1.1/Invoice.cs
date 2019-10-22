using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1._1
{
    class Invoice
    {
        // instance variables for quantity and unit price
        private int quantity;
        private decimal unitPrice;
        
        // create an auto-implemented parameters for part code (string type).
        public string PartCode { get; set; }


        public Invoice()
        {
            quantity = 0;
            unitPrice = 0;
        }

        /* provide properties with get and set accessor for both variables
         * if the value passed to the set accessor is negative, the instance
         * variable should be left unchanged. */
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0.0m)
                {
                    quantity = value;
                }
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;  
            }
            private set
            {
                if (value > 0.0m)
                {
                    unitPrice = value;
                }
            }
        }

        // create a constructor with two parameters, which are used to initialize part code and unit price
        public Invoice(string partCode, decimal unitPrice)
        {
            PartCode = partCode;
            UnitPrice = unitPrice;
        }

        // create a DisplayOrder method to displays part code, unit price and quanitity. Also calculates and display total price
        public string DisplayOrder()
        {
            decimal totalPrice = Quantity * unitPrice;
            string summary = $"Part Code: {PartCode}\n Quantity: {Quantity}\n Unit Price: ${unitPrice}\n Total Price: {totalPrice}";
            return summary;
        }
    }
}
