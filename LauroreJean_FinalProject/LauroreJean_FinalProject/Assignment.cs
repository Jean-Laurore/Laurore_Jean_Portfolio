using System;
using System.Collections.Generic;

namespace LauroreJean_FinalProject
{
    public class Assignment
    {
        //Calling the menu class
        private Menu _myMenu;

        //Creating a list for vehicles
        private List<Vehicle> _vehicle = new List<Vehicle>();

        public Assignment()
        {
            // Display menu
            _myMenu = new Menu("Add Vehicle", "Display Vehicle", "Delete Vehicle", "Exit");
            _myMenu.Title = "Vehicle Monthly Calculator Price";
            _myMenu.Display();
            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("\nMake a selection: ");
            //Checking to see if user type the correct valid number
            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Selection();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        AddVehicle();
                        break;
                    case 2:
                        DisplayVehicle();
                        break;
                    case 3:
                        DeleteVehicle();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        //Second menu 
        private void Selection2()
        {
            _myMenu = new Menu("Car", "Helicopter", "Motorcycle", "Main Menu");
            _myMenu.Title = "Vehicles";
            _myMenu.Display();

            int choice = Validation.ValidateInt("\nMake a selection: ");
            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Selection2();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Car();
                        break;
                    case 2:
                        Helicopter();
                        break;
                    case 3:
                        Motorcycle();
                        break;
                    case 4:
                        MainMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Car()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Car:");
            Console.WriteLine("====");
            Console.WriteLine("====");
            Console.ForegroundColor = ConsoleColor.Gray;

            string make = Validation.ValidateString("\nPlease the make of your car: ");

            string model = Validation.ValidateString("\nPlease enter the model of your car: ");

            int year = Validation.ValidateInt("\nPlease enter the year of your car: ");

            double loanPrice = Validation.ValidateDouble("\nPlease enter the loan amount: ");
            Console.WriteLine("Enter the cost of your your dream car (or the amount you'll need to borrow). It's ok to guess.");

            int loanTerm = Validation.ValidateInt("\nPlease enter term lenght: ");
            Console.WriteLine("How many month would you like to finance your loan? ");

            decimal estimateAPR = Validation.ValidateDecimal("\nPlease enter your estimated APR:");
            Console.WriteLine("This is the interest you'll pay in your loan, which depends on your credit and other factors.");

            //Instantiate the car class
            Car c = new Car(make.ToUpper(), model.ToUpper(), year, estimateAPR, loanPrice, loanTerm);

            //Adding to the vehicle list
            _vehicle.Add(c);

            Console.WriteLine("\nNew Car Created!");



            //Waiting for user to click any key to go back to the second menu
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void Helicopter()
        {

        }

        public void Motorcycle()
        {

        }

        public void MainMenu()
        {
            // Going back to the first menu
            _myMenu = new Menu("Add Vehicle", "Display Vehicle", "Delete Vehicle", "Exit");
            _myMenu.Title = "Vehicle Monthly Calculator Price";
            _myMenu.Display();
            Selection();
        }

        public void AddVehicle()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Vehicle:");
            Console.WriteLine("============");
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Gray;


            Selection2();
        }

        public void DisplayVehicle()
        {

        }

        public void DeleteVehicle()
        {
            Console.Clear();
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display Vehicle:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;


            //Looping in the list for find if theirs vehicles and display them
            int counter = 0;
            Console.WriteLine($"{"  "} {"Make",-10} {"Model",-20} {"Monthly Payments"}");
            foreach (Vehicle vehicle in _vehicle)
            {
                counter++;
                Console.WriteLine($"{counter}. {vehicle.Make.ToUpper(), -10} {vehicle.Model.ToUpper(), -20} {vehicle.Year} {vehicle.Calculation().ToString("C")}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using my Vehicle Monthly Calculator Price. GoodBye!");
        }
    }
}
