using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._00_Students
{
    class Program
    {
        static void Main()
        {
            List<Student> Students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                List<string> currentStudent = input.Split().ToList();

                Student student = new Student();

                student.FirstName = currentStudent[0];
                student.LastName = currentStudent[1];
                student.Age = int.Parse(currentStudent[2]);
                student.HomeTown = currentStudent[3];

                Students.Add(student);
            }

            string city = Console.ReadLine();

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].HomeTown == city)
                {
                    Console.WriteLine(
                        $"{Students[i].FirstName} {Students[i].LastName} is {Students[i].Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}