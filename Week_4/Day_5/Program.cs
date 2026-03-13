
using Examples;


class Program
{
    static void Main()
    {
        Employee emp = new Employee(101, "Hari", 4000, 19);

        Console.WriteLine("Employee ID: " + emp.EmployeeId);
        Console.WriteLine("Name: " + emp.FullName);
        Console.WriteLine("Age: " + emp.Age);
        Console.WriteLine("Salary: " + emp.Salary);

        emp.GiveRaise(15);

        bool result = emp.DeductPenalty(500);

        if (result)
        {
            Console.WriteLine("Penalty deducted. Salary: " + emp.Salary);
        }
        else
        {
            Console.WriteLine("Penalty failed because Salary cannot go below 1000");
        }
    }
}