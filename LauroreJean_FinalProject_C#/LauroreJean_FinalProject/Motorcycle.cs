﻿using System;
namespace LauroreJean_FinalProject
{
    public class Motorcycle:Vehicle
    {
        //Fields
        public new double LoanAmount { get; set; }
        public new int LoanTerms { get; set; }
        public new double EstimatedAPR { get; set; }

        public Motorcycle(string make, string model, string year, double loanAmount, int loanTerms, double estimatedAPR) : base(make, model, year, loanAmount, loanTerms, estimatedAPR)
        {
            EstimatedAPR = estimatedAPR;
            LoanAmount = loanAmount;
            LoanTerms = loanTerms;
        }

        //Overriding the default method in Vehicle class
        public override double Calculation()
        {
            double step1 = EstimatedAPR / 100;
            double step2 = step1 / 12;
            double step3 = step2 * LoanAmount;
            double step4 = step2 + 1;
            double step5 = Math.Pow(step4, 36);
            double step6 = 1 / step5;
            double step7 = 1 - step6;
            double step8 = step3 / step7;

            return Math.Round(step8, 3);
        }

        //Overriding the method in Vehicle class
        public override void Delete()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou have deleted your motorcycle from the list.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
