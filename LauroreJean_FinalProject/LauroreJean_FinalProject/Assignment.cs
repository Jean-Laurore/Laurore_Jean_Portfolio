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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Car:");
            Console.WriteLine("====");
            Console.ForegroundColor = ConsoleColor.Gray;

            string make = Validation.ValidateString("\nPlease the make of your car: ");

            string model = Validation.ValidateString("\nPlease enter the model of your car: ");

            int year = Validation.ValidateInt("\nPlease enter the year of your car: ");

            Console.WriteLine("\nEnter the cost of your your dream car\n(or the amount you'll need to borrow). It's ok to guess.");
            double loanPrice = Validation.ValidateDouble("Please enter the loan amount: ");

            Console.WriteLine("\nHow many month would you like to finance your loan? ");
            int loanTerm = Validation.ValidateInt("Please enter term lenght: ");

            Console.WriteLine("\nThis is the interest you'll pay in your loan,\nwhich depends on your credit and other factors.");
            double estimateAPR = Validation.ValidateDouble("Please enter your estimated APR:");

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
            Console.Clear();
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Display Vehicle:");
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;


            //Looping in the list for find if theirs vehicles and display them
            int counter = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"  "} {"Make",-20} {"Model",-20} {"Year",-10} {"Monthly Payments"}");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Vehicle vehicle in _vehicle)
            {
                counter++;
                Console.WriteLine($"{counter}. {vehicle.Make.ToUpper(), -20} {vehicle.Model.ToUpper(), -20} {vehicle.Year, -10} {vehicle.Calculation().ToString("C")}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();

        }

        public void DeleteVehicle()
        {

        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using my Vehicle Monthly Calculator Price. GoodBye!");
        }
    }
}
