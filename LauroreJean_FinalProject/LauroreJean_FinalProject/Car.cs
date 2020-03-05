using System;
namespace LauroreJean_FinalProject
{
    // Car class inheriting from Vehicle class
    public class Car:Vehicle
    {
        //Fields
        public int Year { get; set; }
        public int EstimateAPR { get; set; }

        public decimal Price { get; set; }

        public Car(string make, string model, int year, int estimateAPR, decimal price):base(make, model)
        {
            Year = year;
            EstimateAPR = estimateAPR;
            Price = price;
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
