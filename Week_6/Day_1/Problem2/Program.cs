using System;
using System.IO;
using System.Threading.Tasks;



namespace ConsoleApp1
{

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Enter Product Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Price:");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Discount:");
                double discount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Calculating...");

              
                double finalPrice = price - (price * discount / 100);

                Console.WriteLine("Final Price: " + finalPrice);

                Console.ReadLine();
            }
        }
    }

