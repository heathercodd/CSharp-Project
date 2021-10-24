using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Model
{
    class Average
    {
        private decimal myAverage;

        public decimal MyAverage
        {
            get
            {
                return myAverage;
            }
            set
            {
                myAverage = value;
            }
        }
        public override string ToString()
        {
            decimal RoundAverage = decimal.Round(MyAverage, 2, MidpointRounding.AwayFromZero);
            return $"Average: £{RoundAverage}";
        }

    }
}
