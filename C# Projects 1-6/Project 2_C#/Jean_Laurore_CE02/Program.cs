using System;

namespace Jean_Laurore_CE02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Laurore Jean
             * Oct 30, 19
             * Code Exercise 02
             */

            // Intro
            //Console.Title = "Problem Analysis";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************************");
            Console.WriteLine("**** Welcome to My Problem Analysis ****");
            Console.WriteLine("****************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();

            //Ask the user a question
            Console.WriteLine("\r\nPlease type in your name");

            //Catch the user response
            //create a variable to hold the user response
            string userName = Console.ReadLine();

            //Say hello to the user
            Console.WriteLine("\r\nHello " + userName + ", welcome!");

            //Prompt the user 
            Console.WriteLine("\r\nEnter scary animal name.");
            //Catch the user response
            //Create a string variable to hold the response
            string userAnimal = Console.ReadLine();

            // Ask the user for a number
            Console.WriteLine("\r\nEnter a number.");
            // A string to hold the user response
            string userNumberString = Console.ReadLine();
            //convert the string to an int
            int userNumber = int.Parse(userNumberString);

            //ask the user for a name
            Console.WriteLine("\r\nPlease type a proffesion like lawyer, doctor or teacher, etc...");
            string userPro = Console.ReadLine();

            //ask the user for a choice name
            Console.WriteLine("\r\nSon or Daughter? Pleased write only one!");
            string userChoice = Console.ReadLine();

            //write a short story to the user
            Console.WriteLine("\r\nIn a world where " + userAnimal + " are stand-up comedians. \r\n" + userNumber + " " + userPro + " has no choice but " +
                "to find another planet to colonise by killing his own " + userChoice +"\r\nAfter a long and drawn out battle, the " + userPro + " saves the day.");
            //Ending with a thank you
            Console.WriteLine("\r\nThank You!");
        }
    }
}
