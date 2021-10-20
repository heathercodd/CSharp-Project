using CSharp_Project.Data.Model;
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
        private readonly IList<Sale> sales;
        public SaleController()
        {
            sales = new List<Sale>();
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

            Sale myNewSale = new Sale(productname, quantity, price, saledate);
            sales.Add(myNewSale);
            Console.WriteLine($"A new sale has been recorded: {myNewSale.ProductName}");
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


                foreach (var sale in sales)
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
