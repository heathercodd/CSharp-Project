using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project.Menus
{
    class SaleMenu
    {
        //this enum contains my menu options
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
                        Console.WriteLine("Data Entry");
                        break;

                    case MainMenu.Reports:
                        Console.WriteLine("Reports");
                        break;

                    case MainMenu.Quit:
                        inMainMenu = false;
                        break;
                }
                


            }


        }


    }
}
