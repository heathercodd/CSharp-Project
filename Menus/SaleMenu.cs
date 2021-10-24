using CSharp_Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Menus
{
    class SaleMenu
    {
        //setting up 
        private readonly SaleController saleController;
        public SaleMenu(SaleController saleController)
        {
            this.saleController = saleController;
        }
        


        //MAIN MENU 

        //this enum contains my main menu options
        public enum MainMenu
        {
            DataEntry, Reports, Quit
        }

        //when this is called, the menu options above will be displayed
        public static void DisplayMainMenu()
        {
            Array options = Enum.GetValues(typeof(MainMenu));
            Console.WriteLine("Sales Main Menu:");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var option in options)
            {
                Console.WriteLine(option);
                Console.WriteLine();
            }

            for (int i= 0; i< 5; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Please type your response:");
            Console.WriteLine();
        }

        //this method makes the main menu options interactive
        public void RunMainMenu()
        {
                                   
            bool inMainMenu = true;                     
            while (inMainMenu)
            {
                Console.Clear();
                DisplayMainMenu();
                string userinput = Console.ReadLine();
                //can we parse the user input to a main menu option? true or false
                bool inputbool = Enum.TryParse(userinput, true, out MainMenu mainMenuOption);

                //ask user to try again 
                if (!inputbool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid input.");
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    continue;
                }

                //carry out an action depending on which option the user selected
                switch (mainMenuOption)
                {
                    case MainMenu.DataEntry:
                        saleController.DataEntrySale();
                        break;

                    case MainMenu.Reports:
                        EnterReportSubmenu();
                        break;

                    case MainMenu.Quit:
                        inMainMenu = false;
                        break;
                }         

            }

        }

        //REPORT SUB MENU 

        //this is how the report submenu will be displayed 
        public static void DisplayReportSubmenu()
        {
            Console.WriteLine("Reports:");
            Console.WriteLine("\n 0. All Sales \n 1. Sales by Year \n 2. Sales by Month and Year \n 3. Total Sales by Year " +
                "\n 4. Total Sales by Year and Month \n 5. Sales Between Selected Year and Selected Year " +
                "\n 6. Sales Between Selected Month / Year and Selected Month / Year \n 7. Average Sales for a Given Month Over Selected Number of Years " +
                "\n 8. Average Sales per Month by Year \n 9. Month with Highest Sales by Year \n 10. Month with Lowest Sales by Year ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Please type the number of the report you would like to view:");
        }      

        //this will run the report submenu 
        public void EnterReportSubmenu()
        {
            bool inReportSubmenu = true;
            while (inReportSubmenu)
            {
                Console.Clear();
                DisplayReportSubmenu();
                string userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "0":
                        saleController.Report0();
                        break;
                    case "1":
                        saleController.Report1();
                        break;
                    case "2":
                        saleController.Report2();
                        break;
                    case "3":
                        saleController.Report3();
                        break;
                    case "4":
                        saleController.Report4();
                        break;
                    case "5":
                        saleController.Report5();
                        break;
                    case "6":
                        saleController.Report6();
                        break;
                    case "7":
                        saleController.Report7();
                        break;
                    case "8":
                        saleController.Report8();
                        break;
                    case "9":
                        saleController.Report9();
                        break;
                    case "10":
                        saleController.Report10();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid input.");
                        Console.WriteLine("Press any key to return to the report menu.");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        continue;
                }
            }

        }

    }
}
