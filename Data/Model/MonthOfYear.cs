using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Model
{
    class MonthOfYear
    {

        private int myMonthOfYear;
        private decimal monthlySales;

        public int MyMonthOfYear
        {
            get
            {
                return myMonthOfYear;
            }
            set
            {
                myMonthOfYear = value;
            }
        }

        public decimal MonthlySales
        {
            get
            {
                return monthlySales;
            }
            set
            {
                monthlySales = value;
            }
        }

        public override string ToString()
        {

            switch (MyMonthOfYear)
            {
                case 1:
                    return $"January, with sales £{MonthlySales}";
                case 2:
                    return $"February, with sales £{MonthlySales}";
                case 3:
                    return $"March, with sales £{MonthlySales}";
                case 4:
                    return $"April, with sales £{MonthlySales}";
                case 5:
                    return $"May, with sales £{MonthlySales}";
                case 6:
                    return $"June, with sales £{MonthlySales}";
                case 7:
                    return $"July, with sales £{MonthlySales}";
                case 8:
                    return $"August, with sales £{MonthlySales}";
                case 9:
                    return $"September, with sales £{MonthlySales}";
                case 10:
                    return $"October, with sales £{MonthlySales}";
                case 11:
                    return $"November, with sales £{MonthlySales}";
                case 12:
                    return $"December, with sales £{MonthlySales}";
                default:
                    return "Not A Month";

            }


          
        }


    }
}
