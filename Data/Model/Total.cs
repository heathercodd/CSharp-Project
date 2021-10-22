using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Model
{
    class Total
    {
        private decimal myTotal;

        public decimal MyTotal
        {
            get
            {
                return myTotal;
            }
            set
            {
                myTotal = value;
            }
        }



        public override string ToString()
        {
            return $"Total Sales: £{MyTotal}";
        }



    }
}
