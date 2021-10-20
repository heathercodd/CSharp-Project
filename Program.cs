using CSharp_Project.Controllers;
using CSharp_Project.Menus;
using System;

namespace CSharp_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //console text will be yellow
            Console.ForegroundColor = ConsoleColor.Yellow;

            //runs the main menu 
            SaleMenu myMenu = new SaleMenu(new SaleController());
            myMenu.RunMainMenu();



        }
    }
}
