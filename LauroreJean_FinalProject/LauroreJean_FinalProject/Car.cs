using System;
namespace LauroreJean_FinalProject
{
    // Car class inheriting from Vehicle class
    public class Car:Vehicle
    {
        //Fields
        public double LoanPrice { get; set; }
        public int LoanTerms { get; set; }
        public decimal EstimateAPR { get; set; }

        public Car(string make, string model, int year, decimal estimateAPR, decimal loanPrice, int loanTerms):base(make, model, year)
        {
            Year = year;
            EstimateAPR = estimateAPR;
            LoanPrice = loanPrice;
            LoanTerms = loanTerms;
        }

        //Overriding the default method in Vehicle class
        public override decimal Calculation()
        {
            return 0;
        }

        //Overriding the method in Vehicle class
        public override void Delete()
        {
            //
        }
    }
}
