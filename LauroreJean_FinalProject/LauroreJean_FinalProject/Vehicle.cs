using System;
using System.Collections.Generic;

namespace LauroreJean_FinalProject
{
    public abstract class Vehicle
    {
        //Fields
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        //Constructor
        public Vehicle(string make, string model, string year) 
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
