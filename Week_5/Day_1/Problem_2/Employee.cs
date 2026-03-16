using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
 

    class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    class Manager : Employee
    {
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.20);
        }
    }

    class Developer : Employee
    {
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.10);
        }
    }

   
}
