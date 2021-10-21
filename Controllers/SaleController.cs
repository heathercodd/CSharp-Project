using CSharp_Project.Data.Model;
using CSharp_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Controllers
{
    class SaleController
    {
        //setting up
        private readonly SaleService saleService;
        public SaleController(SaleService saleService)
        {
            this.saleService = saleService;
        }

        //Data Entry Method
        public void DataEntrySale()
        {               
            Console.WriteLine("What is the product name?");
            string productname = Console.ReadLine();
            Console.WriteLine("What is the quantity?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the price?");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the date of the sale?");
            DateTime saledate = DateTime.Parse(Console.ReadLine());

            //this is the data to enter
            Sale dataToEnter = new Sale() { ProductName = productname, Quantity = quantity, Price = price, SaleDate = saledate };
            
            //passing the data to the service level to be added 
            Sale myNewSale = saleService.DataEntry(dataToEnter);
                       
            Console.WriteLine($"A new sale has been recorded: {myNewSale}");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();

        }

        
        //Report methods
                

        //sales by year report
        public void Report1()
        {
            bool inReport1 = true;
            while (inReport1)
            {
                Console.Clear();
                Console.WriteLine("Sales by Year Report");
                Console.WriteLine();
                Console.WriteLine("Please type the year that you would like to see:");
                int saleyear = Convert.ToInt32(Console.ReadLine());


                Console.Clear();
                Console.WriteLine($"Sales by Year Report for {saleyear}");
                Console.WriteLine();
                Console.WriteLine();

                //pass to service level 
                IEnumerable<Sale> salesInDatabase = saleService.Report1();

                //if the year of a sale matches the user-selected year, show the sale
                foreach (var sale in salesInDatabase)
                {                     
                    if (sale.SaleDate.Year == saleyear)
                    {
                        Console.WriteLine($"Product: {sale.ProductName}, Qty: {sale.Quantity}, Price: {sale.Price}, Date: {sale.SaleDate}");
                    }                   
                    
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key to return.");
                Console.ReadKey();
                continue;


            }

           
        }

        

    }

}
