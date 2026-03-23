using System;
using System.IO;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
        
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));

            Trace.AutoFlush = true;

            Trace.WriteLine("Order Processing Started");

            try
            {
                ValidateOrder();
                ProcessPayment();
                UpdateInventory();
                GenerateInvoice();

                Trace.WriteLine("Order Processing Completed Successfully");
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error Occurred: " + ex.Message);
            }

            Console.WriteLine("Processing Done. Check log.txt file.");
            Console.ReadLine();
        }

        static void ValidateOrder()
        {
            Trace.TraceInformation("Step 1: Validating Order...");
        }

        static void ProcessPayment()
        {
            Trace.TraceInformation("Step 2: Processing Payment...");
        }

        static void UpdateInventory()
        {
            Trace.TraceInformation("Step 3: Updating Inventory...");
        }

        static void GenerateInvoice()
        {
            Trace.TraceInformation("Step 4: Generating Invoice...");
        }
    }
}
