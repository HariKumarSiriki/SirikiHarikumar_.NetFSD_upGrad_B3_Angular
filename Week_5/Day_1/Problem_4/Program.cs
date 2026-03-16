using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Car c = new Car();

            Console.Write("Enter Car Brand: ");
            c.Brand = Console.ReadLine();

            Console.Write("Enter Car Rate Per Day: ");
            c.RentRatePerDay = double.Parse(Console.ReadLine());

            Console.Write("Enter Number of Days: ");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine("Total Car Rental = " + c.CalculateRental(days));

            Console.WriteLine();

            Bike b = new Bike();

            Console.Write("Enter Bike Brand: ");
            b.Brand = Console.ReadLine();

            Console.Write("Enter Bike Rate Per Day: ");
            b.RentRatePerDay = double.Parse(Console.ReadLine());

            Console.WriteLine("Total Bike Rental = " + b.CalculateRental(days));
        }
    }
}
