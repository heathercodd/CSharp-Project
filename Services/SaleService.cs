using CSharp_Project.Data.Model;
using CSharp_Project.Data.Repositories;
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
        private readonly SaleRepository saleRepository;
        public SaleService(SaleRepository saleRepository)
        {
            this.saleRepository = saleRepository;
        }

        //data entry - linking to repository
        internal Sale DataEntry(Sale dataToEnter)
        {
            Sale myNewSale = saleRepository.DataEntry(dataToEnter);
            return myNewSale;
        }

        //sales by year report - linking to repository
        internal IEnumerable<Sale> Report1()
        {            
            return saleRepository.Report1();
        } 









    }
}
