using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace CSharp_Project.Utils
{
    class MySqlUtils
    {
        //building the connection to the database
        public static MySqlConnectionStringBuilder MyConnectionString { get; set; } = new MySqlConnectionStringBuilder
        {
            //details to connect to
            Server = "127.0.0.1",
            UserID = "root",
            Password = "root",
            Port = 3306,
            Database = "sales",
            AllowBatch = true, //batches of com mands can be sent
            AllowLoadLocalInfileInPath = "./", //only files in this directory can be uploaded
            AllowLoadLocalInfile = false, //files cannot be uploaded from anywhere
            ConnectionTimeout = 30 //30 seconds until timeout error
        };

        //connecting to the database
        public static MySqlConnection GetSqlConnection()
        {
            return new MySqlConnection(MyConnectionString.ConnectionString);
        }


        //command to run all text from the provided filepath in sql 
        public static void RunSchemaFile(string filepath, MySqlConnection myConnection)
        {
            string schemafile = File.ReadAllText(filepath);
            MySqlCommand mySqlCommand = myConnection.CreateCommand();
            mySqlCommand.CommandText = schemafile;
            mySqlCommand.ExecuteNonQuery();

        }


    }
}
