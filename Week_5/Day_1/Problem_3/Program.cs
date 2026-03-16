using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Electronics e = new Electronics();

            Console.Write("Enter Electronics Product Name: ");
            e.Name = Console.ReadLine();

            Console.Write("Enter Electronics Price: ");
            e.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Price after 5% discount = " + e.CalculateDiscount());

            Console.WriteLine();

            Clothing c = new Clothing();

            Console.Write("Enter Clothing Product Name: ");
            c.Name = Console.ReadLine();

            Console.Write("Enter Clothing Price: ");
            c.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Price after 15% discount = " + c.CalculateDiscount());
        }
    }
}
