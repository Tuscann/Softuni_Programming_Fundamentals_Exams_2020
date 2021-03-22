using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._00_Students
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                Student newStudent = new Student()
                {
                    FirstName = commands[0],
                    LastName = commands[1],
                    Grade = Double.Parse(commands[2])
                };

                allStudents.Add(newStudent);
            }

            allStudents = allStudents.OrderByDescending(a => a.Grade).ToList();
            
            Console.WriteLine(string.Join("\n",allStudents));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}