﻿using CSharp_Project.Controllers;
using CSharp_Project.Menus;
using CSharp_Project.Utils;
using MySql.Data.MySqlClient;
using System;

namespace CSharp_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //console text will be yellow
            Console.ForegroundColor = ConsoleColor.Yellow;

            /*
            //runs the main menu 
            SaleMenu myMenu = new SaleMenu(new SaleController());
            myMenu.RunMainMenu();

            
            //to create my sale table in the database 
            MySqlConnection connection = MySqlUtils.GetSqlConnection();
            connection.Open();
            MySqlUtils.RunSchemaFile(Environment.CurrentDirectory + @"\Resources\schema.sql", connection);
            connection.Dispose();

            */


        }
    }
}
