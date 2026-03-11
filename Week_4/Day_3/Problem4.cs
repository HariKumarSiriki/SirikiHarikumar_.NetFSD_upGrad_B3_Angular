using System;

class Problem4
{
    static void Main()
    {
        
        int evenCount = 0, oddCount=0, sum=0;
       

        Console.Write("Enter Number: ");
       int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Number must be greater than 0.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;

            if (i % 2 == 0)
            {
                evenCount++;
            }
              
            else
            {
                oddCount++;
            }
              
        }

        Console.WriteLine("Even Count: " + evenCount);
        Console.WriteLine("Odd Count: " + oddCount);
        Console.WriteLine("Sum: " + sum);

        Console.ReadLine();
    }
}