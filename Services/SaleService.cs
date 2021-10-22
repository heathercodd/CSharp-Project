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

        //reports

        //all sales report - linking to repository
        internal IEnumerable<Sale> Report0()
        {
            return saleRepository.Report0();
        }

        //sales by year report - linking to repository
        internal IEnumerable<Sale> Report1(int saleyear)
        {            
            return saleRepository.Report1(saleyear);
        }

        //sales by month and year report - linking to repository
        internal IEnumerable<Sale> Report2(int salemonth, int saleyear)
        {
            return saleRepository.Report2(salemonth, saleyear);
        }

        //total sales by year report - linking to repository 
        internal Total Report3(int saleyear)
        {
            return saleRepository.Report3(saleyear);
        }

        //total sales by month and year report - linking to repository 
        internal Total Report4(int salemonth, int saleyear)
        {
            return saleRepository.Report4(salemonth, saleyear);
        }








    }
}
