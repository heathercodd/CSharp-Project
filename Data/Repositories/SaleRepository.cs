using CSharp_Project.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Repositories
{
    internal class SaleRepository 
    {
        //setting up
        private readonly IList<Sale> sales;
        public SaleRepository()
        {
            sales = new List<Sale>();
        }

        //creating the SaleID 
        private static int id = 0;


        //data entry method
        internal Sale DataEntry(Sale dataToEnter)
        {
            dataToEnter.SaleID = id;
            id++;
            sales.Add(dataToEnter);
            return dataToEnter;
        }

        //report methods

        //report 1
        
        internal IEnumerable<Sale> Report1()
        {
            return sales;
        }





    }
}
