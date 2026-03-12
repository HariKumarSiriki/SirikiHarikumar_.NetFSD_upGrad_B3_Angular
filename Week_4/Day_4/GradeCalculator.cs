using System;

namespace Hands_on
{
    class Student
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            if (m1 < 0 || m2 < 0 || m3 < 0 || m1 > 100 || m2 > 100 || m3 > 100)
            {
                Console.WriteLine("Invaild : Marks must be between 0 and 100");
                return 0;
            }
            else
            {
                return (m1 + m2 + m3) / 3.0;

            }
           
        }

        public char GetGrade(double avg)
        {
            if (avg >= 80)
                return 'A';
            else if (avg >= 60)
                return 'B';
            else if (avg >= 40)
                return 'C';
            else
                return 'F';
        }
    }

   internal class GradeCalculator
    {
        static void Main(string[] args)
        {
            Student s = new Student();

           

            Console.WriteLine("Enter marks1 :");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks2 :");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks3 :");
            int m3 = int.Parse(Console.ReadLine());

            double avg = s.CalculateAverage(m1, m2, m3);

            if (avg > 0)
            {
                char grade = s.GetGrade(avg);
                Console.WriteLine("Average = " + avg);
                Console.WriteLine("Grade = " + grade);
            }

            Console.ReadLine();
        }    
    }
}