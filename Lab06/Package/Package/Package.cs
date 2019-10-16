using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    public class Package : object
    {
        // Four public auto-implemented properties to store the name and address for the package's sender and recipient.
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string RecipName { get; set; }
        public string RecipAddress { get; set; }

        // Two private instance variables to store the weight (ounces) and cost per ounce to ship the package.
        private decimal weight;
        private decimal costPerOunce;

        // Public properties for these instance variables. Values should be 0 or higher. Attempts to store negative 
        // values in them should be ignored.
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Weight)} must be 0 or higher.");
                }
                weight = value;
            }
        }

        public decimal CostPerOunce
        {
            get
            {
                return costPerOunce;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CostPerOunce)} must be 0 or higher.");
                }
                costPerOunce = value;
            }
        }

        // Package's constructor has six parameters: sender's name, sender's address, recipient's name, recipient's address,
        // weight, and cost per ounce. 
        public Package(string senderName, string senderAddress, string recipName, string recipAddress, decimal weight, decimal costPerOunce)
        {
            SenderName = senderName;
            SenderAddress = senderAddress;
            RecipName = recipName;
            RecipAddress = recipAddress;
            Weight = weight; 
            CostPerOunce = costPerOunce;
        }

        // Public virtual method CalculateCost that returns a decimal value for the cost for the shipping the package, which equals
        // the weight multiplied by the cost per ounce. 
        public virtual decimal CalculateCost() => weight * costPerOunce;

    }
}
