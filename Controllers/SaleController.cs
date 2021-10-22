﻿using CSharp_Project.Data.Model;
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
            //collecting information from the user
            Console.Clear();
            Console.WriteLine("New Sale:");
            Console.WriteLine();
            Console.WriteLine("What is the product name?");
            Console.WriteLine();
            string productname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is the quantity?");
            Console.WriteLine();
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What is the price?");
            Console.WriteLine();
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What is the date of the sale?");
            Console.WriteLine();
            DateTime saledate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            //this is the data to enter
            Sale dataToEnter = new Sale() { ProductName = productname, Quantity = quantity, Price = price, SaleDate = saledate };
            
            //passing the data to the service level to be added 
            Sale myNewSale = saleService.DataEntry(dataToEnter);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A new sale has been recorded: {myNewSale}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();

        }

        //Report methods

        //All Sales report
        public void Report0()
        {
            bool inReport0 = true;
            while (inReport0)
            {
                Console.Clear();
                Console.WriteLine("All Sales Report");
                Console.WriteLine();
                Console.WriteLine();

                //pass to service level 
                IEnumerable<Sale> salesInDatabase = saleService.Report0();

                //show all sales
                foreach (var sale in salesInDatabase)
                {
                    Console.WriteLine($"{sale}");
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

        //Sales by Year report
        public void Report1()
        {
            bool inReport1 = true;
            while (inReport1)
            {
                Console.Clear();
                Console.WriteLine("Sales by Year Report");
                Console.WriteLine();
                Console.WriteLine("Please type the year that you would like to see:");
                Console.WriteLine();
                int saleyear = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"Sales by Year Report for {saleyear}");
                Console.WriteLine();
                Console.WriteLine();

                //pass to service level 
                IEnumerable<Sale> salesInDatabase = saleService.Report1(saleyear);

                //show the relevant sales
                foreach (var sale in salesInDatabase)
                {                     
                        Console.WriteLine($"{sale}");                                                         
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

        //Sales by Month and Year report
        public void Report2()
        {
            bool inReport2 = true;
            while (inReport2)
            {
                Console.Clear();
                Console.WriteLine("Sales by Month and Year Report");
                Console.WriteLine();
                Console.WriteLine("Please type the number for the month that you would like to see:");
                Console.WriteLine("\n 01: January \n 02: February \n 03: March \n 04: April \n 05: May \n 06: June \n 07: July \n 08: August \n 09: September \n 10: October \n 11: November \n 12: December");
                Console.WriteLine();
                int salemonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please type the year that you would like to see:");
                Console.WriteLine();
                int saleyear = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"Sales by Month and Year Report for {salemonth}/{saleyear}");
                Console.WriteLine();
                Console.WriteLine();

                //pass to service level 
                IEnumerable<Sale> salesInDatabase = saleService.Report2(salemonth,saleyear);

                //show the relevant sales
                foreach (var sale in salesInDatabase)
                {
                    Console.WriteLine($"{sale}");
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

        //Total Sales by Year report
        public void Report3()
        {
            bool inReport3 = true;
            while (inReport3)
            {
                Console.Clear();
                Console.WriteLine("Total Sales by Year Report");
                Console.WriteLine();
                Console.WriteLine("Please type the year that you would like to see:");
                Console.WriteLine();
                int saleyear = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"Total Sales by Year Report for {saleyear}");
                Console.WriteLine();
                Console.WriteLine();


                Total totalSales = saleService.Report3(saleyear);
                Console.WriteLine($"{totalSales}");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key to return.");
                Console.ReadKey();
                continue;

            }
        }

        //Total Sales by Month and Year report
        public void Report4()
        {
            bool inReport4 = true;
            while (inReport4)
            {   
                Console.Clear();
                Console.WriteLine("Total Sales by Month and Year Report");
                Console.WriteLine();
                Console.WriteLine("Please type the number for the month that you would like to see:");
                Console.WriteLine("\n 01: January \n 02: February \n 03: March \n 04: April \n 05: May \n 06: June \n 07: July \n 08: August \n 09: September \n 10: October \n 11: November \n 12: December");
                Console.WriteLine();
                int salemonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please type the year that you would like to see:");
                Console.WriteLine();
                int saleyear = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"Total Sales by Month and Year Report for {salemonth}/{saleyear}");
                Console.WriteLine();
                Console.WriteLine();

                Total totalSales = saleService.Report4(salemonth,saleyear);
                Console.WriteLine($"{totalSales}");

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
