using System;
namespace LauroreJean_FinalProject
{
    // Car class inheriting from Vehicle class
    public class Car:Vehicle
    {
        //Fields
        public double LoanPrice { get; set; }
        public int LoanTerms { get; set; }
        public double EstimateAPR { get; set; }

        public Car(string make, string model, int year, double estimateAPR, double loanPrice, int loanTerms):base(make, model, year)
        {
            Year = year;
            EstimateAPR = estimateAPR;
            LoanPrice = loanPrice;
            LoanTerms = loanTerms;
        }

        //Overriding the default method in Vehicle class
        public override double Calculation()
        {
            double step1 = EstimateAPR / 100;
            double step2 = step1 / 12;
            double step3 = step2 * LoanPrice;
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
            Console.WriteLine("\nYou have deleted your car from the list.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
