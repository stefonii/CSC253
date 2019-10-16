using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class NegativeNumberException : Exception
    {
        // Default constructor
        public NegativeNumberException() 
            : base("Illegal operation for a negative number.")
        {
            // empty body
        }

        public NegativeNumberException(string messageValue)
            : base(messageValue)
        {
            // empty body
        }

        public NegativeNumberException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {
            // empty body
        }
    }
}
