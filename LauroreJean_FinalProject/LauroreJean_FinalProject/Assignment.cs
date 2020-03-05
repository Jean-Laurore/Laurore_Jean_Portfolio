using System;
using System.Collections.Generic;
using System.IO;

namespace LauroreJean_FinalProject
{
    public class Assignment
    {
        //Calling the menu class
        private Menu _myMenu;

        //Creating a list for vehicles
        private List<Vehicle> _vehicle = new List<Vehicle>();

        //Creating a name for my folder and text
        private string _directory = @"../../../output/";
        private string _fileName = "vehicle.txt";

        public Assignment()
        {
            CreatingFile();
            Load();
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

        //Creating the file to my folder
        public void CreatingFile()
        {
            Directory.CreateDirectory(_directory);

            if (!File.Exists(_directory + _fileName))
            {
                File.Create(_directory + _fileName).Dispose();
                Console.WriteLine("File Created!");

            }
            else
            {
                Console.WriteLine("File exist");
            }
        }


        //Creating a load method to automatically to my display menu
        private void Load()
        {
            using (StreamReader sr = new StreamReader(_directory + _fileName))
            {
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("Kia"))
                    {
                        Car c = new Car("Kia".ToUpper(), "Optima".ToUpper(), "2016", 18000, 60, 15.30);
                        _vehicle.Add(c);
                    }
                    else if (line.Contains("Chevy"))
                    {
                        Car c = new Car("Chevy".ToUpper(), "Camero".ToUpper(), "2016", 22000, 60, 15.25);
                        _vehicle.Add(c);
                    }
                    else if (line.Contains("Honda"))
                    {
                        Car c = new Car("Honda".ToUpper(), "Accord".ToUpper(), "2017", 20000, 60, 15.74);
                        _vehicle.Add(c);
                    }
                }
            }
        }

        public void Car()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Car");
            Console.WriteLine("===========================================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            string make = Validation.ValidateString("\nPlease enter the make of your car: ");

            string model = Validation.ValidateString("\nPlease enter the model of your car: ");

            string year = Validation.ValidateString("\nPlease enter the year of your car: ");
            while (year.Length < 4 || year.Length > 4)
            {
                Console.WriteLine("\nThat is not a valid year. Please try again.");
                year = Validation.ValidateString("\nPlease enter the year of your car: ");
            }

            Console.WriteLine("\nEnter the cost of your your dream car\n(or the amount you'll need to borrow). It's ok to guess.");
            double loanAmount = Validation.ValidateDouble("Please enter the loan amount: ");

            Console.WriteLine("\nHow many month would you like to finance your loan? ");
            int loanTerm = Validation.ValidateInt("Please enter term lenght: ");

            Console.WriteLine("\nThis is the interest you'll pay in your loan,\nwhich depends on your credit and other factors.");
            double estimateAPR = Validation.ValidateDouble("Please enter your estimated APR:");

            //Instantiate the car class
            Car c = new Car(make.ToUpper(), model.ToUpper(), year, loanAmount, loanTerm, estimateAPR);

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
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Helicopter");
            Console.WriteLine("===========================================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            string make = Validation.ValidateString("\nPlease enter the make of your helicopter: ");

            string model = Validation.ValidateString("\nPlease enter the model of your helicopter: ");

            string year = Validation.ValidateString("\nPlease enter the year of your helicopter: ");
            while (year.Length < 4 || year.Length > 4)
            {
                Console.WriteLine("\nThat is not a valid year. Please try again.");
                year = Validation.ValidateString("\nPlease enter the year of your helicopter: ");
            }

            Console.WriteLine("\nEnter the cost of your your dream helicopter\n(or the amount you'll need to borrow). It's ok to guess.");
            double loanAmount = Validation.ValidateDouble("Please enter the loan amount: ");

            Console.WriteLine("\nHow many month would you like to finance your loan? ");
            int loanTerm = Validation.ValidateInt("Please enter term lenght: ");

            Console.WriteLine("\nThis is the interest you'll pay in your loan,\nwhich depends on your credit and other factors.");
            double estimateAPR = Validation.ValidateDouble("Please enter your estimated APR:");

            //Instantiate the car class
            Helicopter h = new Helicopter(make.ToUpper(), model.ToUpper(), year, loanAmount, loanTerm, estimateAPR);

            //Adding to the vehicle list
            _vehicle.Add(h);

            Console.WriteLine("\nNew Helicopter Created!");

            //Waiting for user to click any key to go back to the second menu
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void Motorcycle()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Motorcycle");
            Console.WriteLine("===========================================================");
            Console.ForegroundColor = ConsoleColor.Gray;

            string make = Validation.ValidateString("\nPlease enter the make of your motorcycle: ");

            string model = Validation.ValidateString("\nPlease enter the model of your motorcycle: ");

            string year = Validation.ValidateString("\nPlease enter the year of your motorcycle: ");
            while (year.Length < 4 || year.Length > 4)
            {
                Console.WriteLine("\nThat is not a valid year. Please try again.");
                year = Validation.ValidateString("\nPlease enter the year of your motorcycle: ");
            }

            Console.WriteLine("\nEnter the cost of your your dream motorcycle\n(or the amount you'll need to borrow). It's ok to guess.");
            double loanAmount = Validation.ValidateDouble("Please enter the loan amount: ");

            Console.WriteLine("\nHow many month would you like to finance your loan? ");
            int loanTerm = Validation.ValidateInt("Please enter term lenght: ");

            Console.WriteLine("\nThis is the interest you'll pay in your loan,\nwhich depends on your credit and other factors.");
            double estimateAPR = Validation.ValidateDouble("Please enter your estimated APR:");

            //Instantiate the car class
            Motorcycle m = new Motorcycle(make.ToUpper(), model.ToUpper(), year, loanAmount, loanTerm, estimateAPR);

            //Adding to the vehicle list
            _vehicle.Add(m);

            Console.WriteLine("\nNew Motorcycle Created!");

            //Waiting for user to click any key to go back to the second menu
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Add Vehicle:");
            Console.WriteLine("======================================");
            Console.ForegroundColor = ConsoleColor.Gray;


            Selection2();
        }

        public void DisplayVehicle()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Display Vehicle:");
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;

           
                //Looping in the list for find if theirs vehicles and display them
                int counter = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"  "} {"Make",-10} {"Loan-Amount",-12} {"Loan-Terms",-12} {"Estimated-APR",-15} {"Monthly-Payments"}");
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (Vehicle vehicle in _vehicle)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {vehicle.Make.ToUpper(), -10} {vehicle.LoanAmount.ToString("C"),-15} {vehicle.LoanTerms, -12} {vehicle.EstimatedAPR +"%", -14} {vehicle.Calculation().ToString("C")}");
                }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();

        }

        public void DeleteVehicle()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Delete Vehicle:");
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;

            int counter = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"  "} {"Make",-20} {"Model",-20} {"Year",-10} {"Monthly Payments"}");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Vehicle vehicle in _vehicle)
            {
                counter++;
                Console.WriteLine($"{counter}. {vehicle.Make.ToUpper(),-20} {vehicle.Model.ToUpper(),-20} {vehicle.Year,-10} {vehicle.Calculation().ToString("C")}");
            }


            string make = Validation.ValidateString("\nPlease enter the make of the car to remove: ");

            // DoubleCheck if user really want to delete their vehicle.
            string db = Validation.ValidateString("\nAre you sure? Please type YES OR NO.");

            if (db.Contains("no".ToUpper()) || db.Contains("no".ToLower()))
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            else if (db.Contains("yes".ToUpper()) || db.Contains("yes".ToLower()))
            {
            foreach (Vehicle vehicle in _vehicle)
            {
               if (vehicle.Make.Contains(make.ToUpper()) || vehicle.Make.Contains(make.ToLower()))
               {
                  _vehicle.Remove(vehicle);
                  vehicle.Delete();
                  //break;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    _myMenu.Display();
                    Selection();
               }
                }

            }
            else
            {
                Console.WriteLine("\nPlease only type YES OR NO.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                DeleteVehicle();
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void Exit()
        {
            Console.WriteLine("\nThanks for using my Vehicle Monthly Calculator Price. GoodBye!");
        }
    }
}
