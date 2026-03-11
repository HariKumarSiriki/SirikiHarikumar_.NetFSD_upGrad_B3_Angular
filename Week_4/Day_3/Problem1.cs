using System;

class Problem1
{
    static void Main()
    {
        

        Console.Write("Enter Name: ");
        String name = Console.ReadLine();

        Console.Write("Enter Marks: ");
       int  marks = int.Parse(Console.ReadLine());

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid Marks");
        }
        else if (marks >= 90)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: Fail");
        }

        Console.ReadLine();
    }
}
