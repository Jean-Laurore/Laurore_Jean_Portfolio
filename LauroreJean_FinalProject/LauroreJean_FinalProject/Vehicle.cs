using System;
namespace LauroreJean_FinalProject
{
    public abstract class Vehicle
    {
        //Fields
        public string Make { get; set; }
        public string Model { get; set; }

        //Constructor
        public Vehicle(string make, string model) 
        {
            Make = make;
            Model = model;
        }

        //Defaut method to calculate
        public virtual decimal Calculation()
        {
            return 0;
        }

        //Default method
        abstract public void Delete();
    }
}
