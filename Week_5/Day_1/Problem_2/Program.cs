using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Manager m = new Manager();

            Console.Write("Enter Manager Name: ");
            m.Name = Console.ReadLine();

            Console.Write("Enter Manager Base Salary: ");
            m.BaseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Manager Salary = " + m.CalculateSalary());

            Console.WriteLine();

            Developer d = new Developer();

            Console.Write("Enter Developer Name: ");
            d.Name = Console.ReadLine();

            Console.Write("Enter Developer Base Salary: ");
            d.BaseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Developer Salary = " + d.CalculateSalary());
        }
    }
}
