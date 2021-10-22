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
            command.CommandText = $"INSERT INTO sale (productname, quantity, price) VALUES (@productname, @quantity, @price)";
            //assigning values to the placeholders
            command.Parameters.AddWithValue("@productname",dataToEnter.ProductName);
            command.Parameters.AddWithValue("@quantity", dataToEnter.Quantity);
            command.Parameters.AddWithValue("@price", dataToEnter.Price);            
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
            sale.SaleDate = DateTime.Today;

            return sale;
        }

        //report methods


        //all sales report
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

        //sales between selected year and selected year report
        internal IList<Sale> Report5(int saleyearfrom, int saleyearto)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales between the years selected by the user
            command.CommandText = $"SELECT * FROM sale WHERE year(saledate) >= @saleyearfrom AND year(saledate) <= @saleyearto";
            command.Parameters.AddWithValue("@saleyearfrom", saleyearfrom);
            command.Parameters.AddWithValue("@saleyearto", saleyearto);
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

        //sales between selected month/year and selected month/year report
        internal IList<Sale> Report6(DateTime datefrom, DateTime dateto)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL WHERE statement to filter for sales between the months and years selected by the user
            command.CommandText = $"SELECT * FROM sale WHERE saledate >= @datefrom AND saledate < @dateto";
            command.Parameters.AddWithValue("@datefrom", datefrom);
            command.Parameters.AddWithValue("@dateto", dateto);
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

        //month with highest sales by year report
        internal MonthOfYear Report9(int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL statement to filter for month with highest sales in the year selected by the user
            command.CommandText = $"SELECT MONTH(saledate) AS months, SUM(quantity*price) as monthsales FROM sale WHERE YEAR(saledate) = @saleyear GROUP BY MONTH(saledate) ORDER BY SUM(quantity*price) DESC LIMIT 1;";
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            //read from SQL and assign to the MonthOfYear class 
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int months = reader.GetFieldValue<int>("months");
            decimal monthsales = reader.GetFieldValue<decimal>("monthsales");

            MonthOfYear monthofyear = new MonthOfYear() { MyMonthOfYear = months, MonthlySales =  monthsales};
            Connection.Dispose();
            return monthofyear;
        }

        //month with lowest sales by year report
        internal MonthOfYear Report10(int saleyear)
        {
            MySqlCommand command = Connection.CreateCommand();
            //SQL statement to filter for month with lowest sales in the year selected by the user
            command.CommandText = $"SELECT MONTH(saledate) AS months, SUM(quantity*price) as monthsales FROM sale WHERE YEAR(saledate) = @saleyear GROUP BY MONTH(saledate) ORDER BY SUM(quantity*price) ASC LIMIT 1;";
            command.Parameters.AddWithValue("@saleyear", saleyear);
            Connection.Open();
            command.Prepare();
            //read from SQL and assign to the MonthOfYear class 
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int months = reader.GetFieldValue<int>("months");
            decimal monthsales = reader.GetFieldValue<decimal>("monthsales");

            MonthOfYear monthofyear = new MonthOfYear() { MyMonthOfYear = months, MonthlySales = monthsales };
            Connection.Dispose();
            return monthofyear;
        }








    }


        
}
