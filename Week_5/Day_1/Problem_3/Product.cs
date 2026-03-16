using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
 

    class Product
    {
        private double price;

        public string Name { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid price");
                else
                    price = value;
            }
        }

        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }

    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }
}
