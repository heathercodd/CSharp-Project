using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Model
{
    class Sale
    {
        //creating the data fields to be private
        private int saleID;
        private string productName;
        private int quantity;
        private double price;
        private DateTime saleDate;

        //getting and setting the fields
        public int SaleID
        {
            get
            {
                return saleID;
            }
            set
            {
                saleID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public DateTime SaleDate
        {
            get
            {
                return saleDate;
            }
            set
            {
                saleDate = value;
            }
        }

       
        public Sale(string productname, int quantity, double price, DateTime saledate)
        {
            ProductName = productname;
            Quantity = quantity;
            Price = price;
            SaleDate = saledate;
        }







    }
}
