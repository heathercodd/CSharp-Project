using CSharp_Project.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Services
{
    class SaleService
    {
        //setting up 
        private readonly IList<Sale> sales;
        public SaleService()
        {
            sales = new List<Sale>();
        }
        //creating the SaleID 
        private static int id;

        //data entry
        internal Sale DataEntry(Sale dataToEnter)
        {
            dataToEnter.SaleID = id;
            id++;
            sales.Add(dataToEnter);
            return dataToEnter;
        }

        //sales by year report
        internal IEnumerable<Sale> Report1()
        {
            return sales;
        } 









    }
}
