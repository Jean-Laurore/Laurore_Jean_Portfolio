using System;
namespace LauroreJean_FinalProject
{
    public abstract class Vehicle
    {
        //Fields
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //Constructor
        public Vehicle(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
        }

        //Defaut method to calculate
        public virtual double Calculation()
        {
            return 0;
        }

        //Default method
        abstract public void Delete();
    }
}
