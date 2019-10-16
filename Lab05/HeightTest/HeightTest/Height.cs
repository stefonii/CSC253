using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightTest
{
    class Height
    {
        // Two private instance variables foot and inch (int).
        private int foot;
        private int inch;

        // Constructor: if two arguments are passed in, the first one will be foot while the second one will be inch.
        public Height(int foot = 0, int inch = 0)
        {
            setFH(foot, inch);
        }

        // Constructor: if another Height object is passed in, copy the values of its foot and inch.
        public Height(Height h)
            : this(h.Foot, h.Inch) { }

        public void setFH(int foot, int inch)
        {
            Foot = foot;
            Inch = inch;
        }

        // Create public properties for these two instance variables. Each property has a getter and setter. 
        public int Foot
        {
            get
            {
                return foot;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Foot)} must be 0 or larger.");
                }
                foot = value;
            }
        }

        public int Inch
        {
            get
            {
                return inch;
            }
            set
            {
                if (value < 0 || value > 11)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Inch)} must be between 0 and 11.");
                }
                inch = value;
            }
        }
    }
}
