using System;

namespace _03._00_Elevator
{
    class Program
    {
        static void Main()
        {
            int totalPersons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int neededCourses = totalPersons / capacity;

            if (totalPersons % capacity != 0)
            {
                neededCourses += 1;
            }

            Console.WriteLine(neededCourses);
        }
    }
}