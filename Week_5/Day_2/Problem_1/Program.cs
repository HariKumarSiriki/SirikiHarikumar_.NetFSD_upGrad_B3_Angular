using System;


public record Student(int roll, string name, string course, int marks);

class Program
{
    static Student[] students;
    static int count = 0;
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        students = new Student[n];
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add();
                    break;

                case 2:
                    show();
                    break;

                case 3:
                    search();
                    break;

                case 4:
                    Console.WriteLine("Bye");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
    static void add()
    {
        if (count == students.Length)
        {
            Console.WriteLine("Array is full");
            return;
        }

        Console.Write("Roll: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Name: ");
        string n = Console.ReadLine();

        Console.Write("Course: ");
        string c = Console.ReadLine();

        Console.Write("Marks: ");
        int m = Convert.ToInt32(Console.ReadLine());

        students[count] = new Student(r, n, c, m);
        count++;

        Console.WriteLine("Added");
    }
    static void show()
    {
        if (count == 0)
        {
            Console.WriteLine("No data");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(students[i].roll + " " +
                              students[i].name + " " +
                              students[i].course + " " +
                              students[i].marks);
        }
    }
        static void search()
    {
        Console.Write("Enter roll: ");
        int r = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (students[i].roll == r)
            {
                Console.WriteLine("Found: " + students[i].name);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found");
        }
    }
}