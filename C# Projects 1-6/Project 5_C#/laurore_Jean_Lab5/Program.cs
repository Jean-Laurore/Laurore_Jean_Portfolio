using System;

namespace laurore_Jean_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * November 6, 19
             * Lab 5
             * SDI
             */

            // Setting the background color & title
            // Set up Console UI (CUI)
            Console.Title = "Rudimentary Calculator";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************************");
            Console.WriteLine("**** Welcome To Rudimentary Calculator! ****");
            Console.WriteLine("********************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // wait for enter key to be pressed.
            Console.WriteLine("\r\nPlease press Enter/Return to continue...");
            Console.ReadLine();


            string userInput;
            string userInput2;
            string userOperator;
            string operatorEnter;
            double inputNumber;
            double inputNumber2;
            double result;
            //double result1 = 0;
            //double result2 = 0;
            //double result3 = 0;

            //Get the user input
            Console.WriteLine("\r\nPlease enter your number:");
            userInput = Console.ReadLine();

            //Validate using method
            inputNumber = ValidateDouble(userInput);


            // Write back to the user
            Console.WriteLine("\r\nYou have enter the number " + userInput);

            //send user input
            Console.WriteLine("\r\nPlease enter another number:");
            userInput2 = Console.ReadLine();

            //Validate
            inputNumber2 = ValidateDouble(userInput2);

            //Ask user for an operator
            Console.WriteLine("\r\nPlease enter your operation ( *, /, +, -): ");
            userOperator = Console.ReadLine();

            //validate the operation to string
            operatorEnter = GetMyOperator(userOperator);

            //write out to the user
            Console.WriteLine("\r\nYou have enter " + userOperator);


            //Invoke
            result = GetFinal(userOperator, inputNumber, inputNumber2);


            //Goodbye
            Console.WriteLine("\r\nThanks, bye now!");

            //Console.WriteLine("r\nYour total is: " + result);
            //result = Multi(inputNumber, inputNumber2);
            //result1 = Div(inputNumber, inputNumber2);
            //result2 = Add(inputNumber, inputNumber2);
            //result3 = Sub(inputNumber, inputNumber2);

            //Conditional
            //if (operatorEnter == "*")
            //{
            //    Console.WriteLine("\r\nYour total is: " + result);
            //}
            //else if (operatorEnter == "/")
            //{
            //    Console.WriteLine("\r\nYour total is: " + result1);
            //}
            //else if (operatorEnter == "+")
            //{
            //    Console.WriteLine("\r\nYour total is: " + result2);
            //}
            //else if (operatorEnter == "-")
            //{
            //    Console.WriteLine("\r\nYour total is: " + result3);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Operator! ");
            //}

            ////Goodbye
            //Console.WriteLine("\r\nThanks, bye now!");

        }

        public static double ValidateDouble(string userNumber)
        {
            // to hold the converted value
            double convertedNumber;

            //Create a loop to validate
            while (!double.TryParse(userNumber, out convertedNumber))
            {
                //output to the user
                Console.WriteLine("\r\nError! Please type a valid number.");
                userNumber = Console.ReadLine();
            }
            //return the double
            return convertedNumber;

        }

        public static string GetMyOperator(string userString)
        {
            while (string.IsNullOrWhiteSpace(userString))
            {
                //ask 
                Console.WriteLine("\r\nError! Please enter an operator: ");
                userString = Console.ReadLine();
            }

            return userString;
        }

        //Method to do calculation
        public static double GetFinal(string op, double num1, double num2)
        {
            double answer = 0;
            //Conditional
            if (op == "*")
            {
               // double answer;
                answer = num1 * num2;
                Console.WriteLine("\r\nYour total is: " + answer);
                return answer;

            }
            else if (op == "/")
            {
                //double answer;
                answer = num1 / num2;
                Console.WriteLine("\r\nYour total is: " + answer);
                return answer;
            }
            else if (op == "+")
            {
                //double answer;
                answer = num1 + num2;
                Console.WriteLine("\r\nYour total is: " + answer);
                return answer;
            }
            else if (op == "-")
            {
                //double answer;
                answer = num1 - num2;
                Console.WriteLine("\r\nYour total is: " + answer);
                return answer;
            }
            else
            {
                Console.WriteLine("Wrong Operator! ");
            }
            //Goodbye
            //Console.WriteLine("\r\nThanks, bye now!");

            //double answer;
            //answer = num1 * num2;
            return answer;
        }
        ////Method for dividing
        //public static double Div(double num1, double num2)
        //{
        //    double answer;
        //    answer = num1 / num2;
        //    return answer;
        //}
        ////method for adding
        //public static double Add(double num1, double num2)
        //{
        //    double answer;
        //    answer = num1 + num2;
        //    return answer;
        //}
        ////method for subtraction
        //public static double Sub(double num1, double num2)
        //{
        //    double answer;
        //    answer = num1 - num2;
        //    return answer;
        //}
    }
}
