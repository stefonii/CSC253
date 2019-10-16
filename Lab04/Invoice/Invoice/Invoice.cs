using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        string partNum;
        string partDescription;
        int quantity;
        decimal unitPrice;

        public Invoice(string pNum, string pDescription, int q, decimal uPrice)
        {
            partNum = pNum;
            partDescription = pDescription;
            quantity = q;
            unitPrice = uPrice;
        }

        public string PartNum
        {
            get
            {
                return partNum;
            } // end get
            set
            {
                partNum = value;
            } // end set
        } // end

        public string PartDescription
        {
            get
            {
                return partDescription;
            } // end get
            set
            {
                partDescription = value;
            } // end set
        } //end

        public int Quantity
        {
            get
            {
                return quantity;
            } // end get
            set
            {
                if (value >= 0)
                    quantity = value;
            } // end set
        } // end

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            } // end get
            set
            {
                if (value >= 0M)
                    unitPrice = value;
            } // end set
        } // end

        public decimal GetInvoiceAmount()
        {
            decimal amt = Quantity * UnitPrice;
            return amt;
        }

        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}{3,10:C}", PartNum, PartDescription, Quantity, UnitPrice);
        }
    }
}
