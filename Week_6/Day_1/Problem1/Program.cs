using System;
using System.IO;
using System.Threading.Tasks;



namespace ConsoleApp1
{ 
        class Program
        {
            static async Task Main()
            {
                Console.WriteLine("Application Started...\n");

                Task log1 = WriteLogAsync("User login successfull");
                Task log2 = WriteLogAsync("Files uploaded successfully");
                Task log3 = WriteLogAsync("Payment successful");

                Console.WriteLine("Main is free to do other works...\n");

                await Task.WhenAll(log1, log2, log3);

                Console.WriteLine("\n All logs written successfully");
                Console.ReadLine();
            }

            public static async Task WriteLogAsync(string message)
            {
            Console.WriteLine($"Start writing log: {message}");
                    await Task.Delay(2000);

                Console.WriteLine($"Finished writing log: {message}");
            }
        }
    }
