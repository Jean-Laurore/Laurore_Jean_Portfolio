using System;

namespace Laurore_Jean_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * 11-8-19
             * Lab6
             */

            // Setting the background color & title
            // Set up Console UI (CUI)
            Console.Title = "Shirt Size";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************");
            Console.WriteLine("**** Welcome to Shirt Size! ****");
            Console.WriteLine("********************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // wait for enter key to be pressed.
            Console.WriteLine("\r\nPlease press Enter/Return to continue...");
            Console.ReadLine();

            //ask the user a question
            Console.WriteLine("\r\nPlease enter your shirt size.");
            Console.WriteLine("Notes: Only type S, M, L OR XL. Thank You!");
            string userInput = Console.ReadLine();

            ValidateString(userInput);
            

            ShirtSizes(userInput);
        }

        public static void ShirtSizes(string userSize)
        {
            // Create an list
            string[] sizes = { "s", "s", "l", "m", "l", "s", "m", "l", "xl", "l", "m", "s" };

            int smallCountSize = 0;
            int mediumCountSize = 0;
            int largeCountSize = 0;
            int xLargeCountSize = 0;


            for (int i = 0; i < sizes.Length; i++)
            {
                if (sizes[i] == "s")
                {
                    smallCountSize++;

                }

                else if (sizes[i] == "m")
                {
                    mediumCountSize++;

                }

                else if (sizes[i] == "l")
                {
                    largeCountSize++;

                }

                else if (sizes[i] == "xl")
                {
                    xLargeCountSize++;

                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }

            Console.WriteLine("Only " + smallCountSize + " Small Shirt(s) available.");
            Console.WriteLine("Only " + mediumCountSize + " Medium Shirt(s) available.");
            Console.WriteLine("Only " + largeCountSize + " Large Shirt(s) available.");
            Console.WriteLine("Only " + xLargeCountSize + " XL Shirt(s) available.");

            
        }
        public static string ValidateString(string userString)
        {
            // create a while loop
            while (string.IsNullOrWhiteSpace(userString))
            {
                Console.WriteLine("Error! Please try again!");
                userString = Console.ReadLine();
            }
            //return the userstring
            return userString;
        }
    }
    }
