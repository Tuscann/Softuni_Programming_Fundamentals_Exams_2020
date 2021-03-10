using System;

namespace _01._00_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }

        private static void Print(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}