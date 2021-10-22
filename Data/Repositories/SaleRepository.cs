using CSharp_Project.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Data.Repositories
{
    internal class SaleRepository 
    {
        //setting up the SQL connection
        public MySqlConnection Connection { get; }
        public SaleRepository(MySqlConnection mySqlConnection)
        {
            Connection = mySqlConnection;
        }


        //data entry method
        internal Sale DataEntry(Sale dataToEnter)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL command using placeholders
            command.CommandText = $"INSERT INTO sale (productname, quantity, price, saledate) VALUES (@productname, @quantity, @price, @saledate)";
            //assigning values to the placeholders
            command.Parameters.AddWithValue("@productname",dataToEnter.ProductName);
            command.Parameters.AddWithValue("@quantity", dataToEnter.Quantity);
            command.Parameters.AddWithValue("@price", dataToEnter.Price);
            command.Parameters.AddWithValue("@saledate", dataToEnter.SaleDate);
            //SQL connection and query execution 
            Connection.Open();
            command.Prepare();
            command.ExecuteNonQuery();
            Connection.Dispose();
            //creating the new sale 
            Sale sale = new Sale();
            sale.SaleID = Convert.ToInt32(command.LastInsertedId);
            sale.ProductName = dataToEnter.ProductName;
            sale.Quantity = dataToEnter.Quantity;
            sale.Price = dataToEnter.Price;
            sale.SaleDate = dataToEnter.SaleDate;
            return sale;
        }

        //report methods


        //sales by year report
        internal IList<Sale> Report0()
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL statement to show all sales 
            command.CommandText = $"SELECT * FROM sale";            
            Connection.Open();
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();

            //creating a list of all sales 

            IList<Sale> sales = new List<Sale>();

            while (reader.Read())
            {
                int saleid = reader.GetFieldValue<int>("saleid");
                string productname = reader.GetFieldValue<string>("productname");
                int quantity = reader.GetFieldValue<int>("quantity");
                decimal price = reader.GetFieldValue<decimal>("price");
                DateTime saledate = reader.GetFieldValue<DateTime>("saledate");

                Sale sale = new Sale() { SaleID = saleid, ProductName = productname, Quantity = quantity, Price = price, SaleDate = saledate };
                sales.Add(sale);
            }

            Connection.Dispose();
            return sales;
        }

        //sales by year report
        internal IList<Sale> Report1(int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales in the year selected by the user
            command.CommandText = $"SELECT * FROM sale WHERE year(saledate) = @saleyear";
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();

            //creating a list of the relevant sales 

            IList<Sale> sales = new List<Sale>();

            while (reader.Read())
            {
                int saleid = reader.GetFieldValue<int>("saleid");
                string productname = reader.GetFieldValue<string>("productname");
                int quantity = reader.GetFieldValue<int>("quantity");
                decimal price = reader.GetFieldValue<decimal>("price");
                DateTime saledate = reader.GetFieldValue<DateTime>("saledate");

                Sale sale = new Sale() {SaleID = saleid, ProductName = productname, Quantity = quantity, Price = price, SaleDate = saledate};
                sales.Add(sale);
            }

            Connection.Dispose();
            return sales;
        }



        //sales by month and year report
        internal IList<Sale> Report2(int salemonth, int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales in the month and year selected by the user
            command.CommandText = $"SELECT * FROM sale WHERE year(saledate) = @saleyear AND month(saledate) = @salemonth";
            command.Parameters.AddWithValue("@salemonth", salemonth);
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();

            //creating a list of the relevant sales 

            IList<Sale> sales = new List<Sale>();

            while (reader.Read())
            {
                int saleid = reader.GetFieldValue<int>("saleid");
                string productname = reader.GetFieldValue<string>("productname");
                int quantity = reader.GetFieldValue<int>("quantity");
                decimal price = reader.GetFieldValue<decimal>("price");
                DateTime saledate = reader.GetFieldValue<DateTime>("saledate");

                Sale sale = new Sale() { SaleID = saleid, ProductName = productname, Quantity = quantity, Price = price, SaleDate = saledate };
                sales.Add(sale);
            }

            Connection.Dispose();
            return sales;
        }


        //total sales by year report
        internal Total Report3(int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales in the year selected by the user
            command.CommandText = $"SELECT SUM(quantity*price) AS totalsales FROM sale WHERE year(saledate) = @saleyear";
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            //read from SQL and assign to the Total class 
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            decimal totalsales = reader.GetFieldValue<decimal>("totalsales");
            Total total = new Total() { MyTotal = totalsales };
            Connection.Dispose();
            return total;

        }


        //total sales by month and year report
        internal Total Report4(int salemonth, int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales in the month and year selected by the user
            command.CommandText = $"SELECT SUM(quantity*price) AS totalsales FROM sale WHERE year(saledate) = @saleyear AND month(saledate) = @salemonth";
            command.Parameters.AddWithValue("@salemonth", salemonth);
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            //read from SQL and assign to the Total class 
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            decimal totalsales = reader.GetFieldValue<decimal>("totalsales");
            Total total = new Total() { MyTotal = totalsales };
            Connection.Dispose();
            return total;

        }




    }
}
