using System;

namespace LauroreJean_PR01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * Oct 1, 19
             * lab3
             */

            //Set up Console UI(CUI)
            //Intro
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("**** Welcome to my Shopping Cart Calculator ****");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("\r\nPlease press Enter/Return to continue...");

            // wait for enter key to be pressed.
            Console.ReadLine();

            
            //Variables
            //string userInput;
            string userDiscount = "Yes";
            //string userDiscount1;
            decimal userDiscountAmount = 15;
            string userStateInput = "Florida";
            //string userStateInput2 = "";
            //string userStateInput1;
            decimal userSaleTax = 0.06m;
            decimal userSaleTax2 = 0.10m;
            //decimal userInputDeci;



            //ask the user for an input
            Console.WriteLine("\r\nPlease type in the cost for your PC:");
            string userInputString = Console.ReadLine();
            //convert
            decimal userInput = decimal.Parse(userInputString);

            // Ask the user if they want to see if they qualify
            Console.WriteLine("\r\nWould you like to see if you qualify for a discount? Please type in Yes or No.");
            Console.WriteLine("Note: Make sure it a Uppercase Y or N.");
            userDiscount = Console.ReadLine();

            decimal pcTotal = userInput - userDiscountAmount;
            decimal pcTotal2 = pcTotal * userSaleTax;
            decimal pcTotal3 = pcTotal2 + pcTotal;

            decimal otherStateTotal = pcTotal;
            decimal otherStateTotal1 = otherStateTotal * userSaleTax2;
            decimal otherStateTotal2 = otherStateTotal1 + otherStateTotal;

            //Conditional
            if (userDiscount == "Yes")
            {
                Console.WriteLine("\r\n15% off your item.");

                Console.WriteLine("\r\nPlease type in the state you live in:");
                userStateInput = Console.ReadLine();

                // if user type Florida
                if (userStateInput == "Florida")
                {
                    Console.WriteLine("Your sale tax will be 6%.");
                    Console.WriteLine("Total cost of PC is: " + userInput);
                    Console.WriteLine("Total cost of PC with discount is: " + pcTotal);
                    Console.WriteLine("Total cost of PC with discount and sale tax is: " + pcTotal3);
                    Console.WriteLine("GrandTotal cost for Floridian is: " + pcTotal3);
                }
                // if user input Other State
                else
                {
                    Console.WriteLine("Your sale tax is 10%");
                    Console.WriteLine("Total cost of PC is: " + userInput);
                    Console.WriteLine("Total cost of PC with discount is: " + pcTotal);
                    //Console.WriteLine("Total cost of PC with discount and sale tax is: " + otherStateTotal2);
                    Console.WriteLine("GrandTotal cost for other states is: " + otherStateTotal2);
                }
            }
            if (userDiscount == "No")
            {
                Console.WriteLine("No discount applied.");

                Console.WriteLine("\r\nPlease type in the state you live in:");
                userStateInput = Console.ReadLine();

                // if user type Florida
                if (userStateInput == "Florida")
                {
                    Console.WriteLine("Your sale tax will be 6%.");
                    Console.WriteLine("Total cost of PC is: " + userInput);
                    Console.WriteLine("Total cost of PC with discount is: " + pcTotal);
                    Console.WriteLine("Total cost of PC with discount and sale tax is: " + pcTotal3);
                    Console.WriteLine("GrandTotal cost for Floridian is: " + pcTotal3);
                }
                // if user input Other State
                else
                {
                    Console.WriteLine("Your sale tax is 10%");
                    Console.WriteLine("Total cost of PC is: " + userInput);
                    Console.WriteLine("Total cost of PC with discount is: " + pcTotal);
                    //Console.WriteLine("Total cost of PC with discount and sale tax is: " + otherStateTotal2);
                    Console.WriteLine("GrandTotal cost for other states is: " + otherStateTotal2);
                }
            }
            Console.WriteLine("\r\nThanks for using my program!");
        }
    }
}
