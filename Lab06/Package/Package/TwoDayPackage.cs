using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    public class TwoDayPackage : Package
    {
        // Private instance variable and corresponding public property to store a flat fee the shipping company charges for two-day delivery service. 
        // Flat fee should be 0 or higher. 
        private decimal flatFee;

        public decimal FlatFee
        {
            get
            {
                return flatFee;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FlatFee)} should be 0 or higher.");
                }
                flatFee = value;
            }
        }

        // Constructor should have an additional parameter for this flat fee. 
        public TwoDayPackage(string senderName, string senderAddress, string recipName, string recipAddress, decimal weight, decimal costPerOunce, decimal flatFee) : base(senderName, senderAddress, recipName, recipAddress, weight, costPerOunce)
        {
            FlatFee = flatFee;
        }

        // Redefine method CalculateCost so that it computes the shipping cost by adding the flat fee to the weight-based cost calculated by base class's CalculateCost method.
        public override decimal CalculateCost() => flatFee + (Weight * CostPerOunce);

    }
}
