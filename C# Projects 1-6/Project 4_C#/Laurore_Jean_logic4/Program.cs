using System;

namespace Laurore_Jean_logic4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * 11-4-19
             * Logic 4
             */

            

            //Setting the background color & title
            // Set up Console UI (CUI)
            Console.Title = "My Theater";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\n*******************************");
            Console.WriteLine("**** Welcome to My Theater ****");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // wait for enter key to be pressed.
            Console.WriteLine("\r\nPlease press Enter/Return to continue...");
            Console.ReadLine();

            decimal normalPrice = 12.00m;
            decimal priceDiscount = 7.00m;
            //decimal finalPrice = normalPrice - priceDiscount;

            //Prompt the user
            Console.WriteLine("\r\nPlease type in your age. Then press return/enter.");
            //Capture the user response
            string userAgeString = Console.ReadLine();
            //Convert to dataType
            decimal userAge = decimal.Parse(userAgeString);

            //Start out conditional
            if (userAge < 10 || userAge >= 55)
            {
                Console.WriteLine("\r\nYour cost for your ticket is $" + priceDiscount);
            }

            else
            {
                Console.WriteLine("\r\nYour cost for your ticket is $" + normalPrice);
            }


            //Intro
            //Console.WriteLine("\r\nWelcome to tire pressure!");

            //Setting the background color & title
            // Set up Console UI (CUI)
            Console.Title = "Tire Pressure";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\n*************************************");
            Console.WriteLine("**** Welcome to My Tire Pressure ****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // wait for enter key to be pressed.
            Console.WriteLine("\r\nPlease press Enter/Return to continue...");
            Console.ReadLine();

            //Ask a question
            Console.WriteLine("\r\nPlease type your car first front tires pressure:");
            //Capture
            string userInputString = Console.ReadLine();
            //Convert
            int userInput = int.Parse(userInputString);

            Console.WriteLine("\r\nPlease type your car second front tires pressure:");
            //Capture
            string userInputString1 = Console.ReadLine();
            //Convert
            int userInput1 = int.Parse(userInputString1);

            //Ask a question
            Console.WriteLine("\r\nPlease type your car back first tires pressure:");
            //Capture
            string userInputString2 = Console.ReadLine();
            //Convert
            int userInput2 = int.Parse(userInputString2);

            //Ask a question
            Console.WriteLine("\r\nPlease type your car back second tires pressure:");
            //Capture
            string userInputString3 = Console.ReadLine();
            //Convert
            int userInput3 = int.Parse(userInputString3);

            //Back tire pressure: 30
            //Front tire pressure: 22

            if (userInput == 30 && userInput1 == 30 && userInput2 == 30 && userInput3 == 30)
            {
                Console.WriteLine("\r\nYour tires have met maintenance standards.");
            }
            else
            {
                Console.WriteLine("\r\nYour tires need specifications.");
            }

            Console.WriteLine("\r\nThank you for using my program. Good Bye!");
        }

    }
}
