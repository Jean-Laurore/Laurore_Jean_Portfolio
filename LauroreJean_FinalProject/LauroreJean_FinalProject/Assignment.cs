using System;

namespace LauroreJean_FinalProject
{
    public class Assignment
    {
        //Calling the menu class
        private Menu _myMenu;

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

        }

        public void Exit()
        {

        }
    }
}
