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

        //sales between selected year and selected year report - linking to repository
        internal IEnumerable<Sale> Report5(int saleyearfrom, int saleyearto)
        {
            return saleRepository.Report5(saleyearfrom, saleyearto);
        }

        //sales between selected month/year and selected month/year report - linking to repository
        internal IEnumerable<Sale> Report6(DateTime datefrom, DateTime dateto)
        {
            return saleRepository.Report6(datefrom, dateto);
        }

        //average sales for a given month over selected number of years report - linked to repository
        internal Average Report7(int salemonth, int numofyears)
        {
            return saleRepository.Report7(salemonth, numofyears);
        }

        //average sales per month by year report - linking to repository
        internal Average Report8(int saleyear)
        {
            return saleRepository.Report8(saleyear);
        }

        //month with highest sales by year report - linking to repository
        internal MonthOfYear Report9(int saleyear)
        {
            return saleRepository.Report9(saleyear);
        }

        //month with lowest sales by year report - linking to repository
        internal MonthOfYear Report10(int saleyear)
        {
            return saleRepository.Report10(saleyear);
        }






    }
}
