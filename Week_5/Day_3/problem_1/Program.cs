using ConsoleApp1;
using System;

using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        int choice;

        while (true)
        {
            Console.WriteLine("\nTo-Do List Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(task))
                    {
                        tasks.Add(task);
                        Console.WriteLine("Task added!");
                    }
                    else
                    {
                        Console.WriteLine("Task cannot be empty.");
                    }
                    break;

                case 2:
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        Console.WriteLine("Tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case 3:
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks to remove.");
                        break;
                    }

                    Console.Write("Enter task number to remove: ");
                    int num;

                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else if (num < 1 || num > tasks.Count)
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    else
                    {
                        string removed = tasks[num - 1];
                        tasks.RemoveAt(num - 1);
                        Console.WriteLine("Removed: " + removed);
                    }
                    break;

                case 4:
                    Console.WriteLine("Exited");
                    return;

                default:
                    Console.WriteLine("Invalid choice Please choose correct choice");
                    break;
            }
        }
    }
}
