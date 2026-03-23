using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Starting Reports...\n");

            var task1 = GenerateSalesReportAsync();
            var task2 = GenerateInventoryReportAsync();
            var task3 = GenerateCustomerReportAsync();

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("\nAll Reports Completed!");
            Console.ReadLine();
        }

        static async Task GenerateSalesReportAsync()
        {
            Console.WriteLine("Sales Report Started");
            await Task.Delay(2000);
            Console.WriteLine("Sales Report Completed");
        }

        static async Task GenerateInventoryReportAsync()
        {
            Console.WriteLine("Inventory Report Started");
            await Task.Delay(3000);
            Console.WriteLine("Inventory Report Completed");
        }

        static async Task GenerateCustomerReportAsync()
        {
            Console.WriteLine("Customer Report Started");
            await Task.Delay(2500);
            Console.WriteLine("Customer Report Completed");
        }
    }
}