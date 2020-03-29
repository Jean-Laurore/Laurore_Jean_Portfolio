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

        public double LoanAmount { get; set; }
        public double EstimatedAPR { get; set; }

        public int LoanTerms { get; set; }


        //Constructor
        public Vehicle(string make, string model, string year, double loanAmount, int loanTerms, double estimatedAPR) 
        {
            Make = make;
            Model = model;
            Year = year;
            LoanAmount = loanAmount;
            LoanTerms = loanTerms;
            EstimatedAPR = estimatedAPR;
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
