using System;

namespace _01._00_Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number/1000M:f2}");
        }
    }
}