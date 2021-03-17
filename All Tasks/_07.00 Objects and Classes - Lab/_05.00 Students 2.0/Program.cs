using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Students_2._0
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

                bool isfound = IsStudentExict(Students, currentStudent);

                if (isfound)
                {
                    Students.Add(student);
                }
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

        private static bool IsStudentExict(List<Student> Students, List<string> currentStudent)
        {
            bool isfound = true;

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].FirstName == currentStudent[0] && Students[i].LastName == currentStudent[1])
                {
                    Students[i].Age = int.Parse(currentStudent[2]);
                    Students[i].HomeTown = currentStudent[3];
                    isfound = false;
                }
            }

            return isfound;
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