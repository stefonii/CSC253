using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    public class OvernightPackage : Package
    {
        // Private instance variable (and corresponding public property) representing an additional fee per ounce charged for overnight delivery service.
        // Fee should be 0 or higher.
        private decimal addFeePerOunce;

        public decimal AddFeePerOunce
        {
            get
            {
                return addFeePerOunce;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(AddFeePerOunce)} must be 0 or higher.");
                }
                addFeePerOunce = value;
            }
        }

        // Constructor should have an additional parameter for this additional fee per ounce. 
        public OvernightPackage(string senderName, string senderAddress, string recipName, string recipAddress, decimal weight, decimal costPerOunce, decimal addFeePerOunce) : base(senderName, senderAddress, recipName, recipAddress, weight, costPerOunce)
        {
            AddFeePerOunce = addFeePerOunce;
        }

        // Redefine CalculateCost method so that it adds the additional fee per ounce to the standard cost per ounce when calculating the shipping cost.
        public override decimal CalculateCost() => (Weight * addFeePerOunce) + (Weight * CostPerOunce);
    }
}
