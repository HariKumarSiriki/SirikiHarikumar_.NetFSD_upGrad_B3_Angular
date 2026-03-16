using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    using System;

    class Vehicle
    {
        public string Brand { get; set; }
        public double RentRatePerDay { get; set; }

        public virtual double CalculateRental(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Invalid days");
                return 0;
            }

            return RentRatePerDay * days;
        }
    }

    class Car : Vehicle
    {
        public override double CalculateRental(int days)
        {
            double total = RentRatePerDay * days;
            return total + 500;
        }
    }

    class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            double total = RentRatePerDay * days;
            return total - (total * 0.05);
        }
    }

   
}
