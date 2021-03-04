using System;

namespace _02._00_Division
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool isFound = true;

            if (number % 10 == 0)
            {
                number = 10;
            }
            else  if (number % 7 == 0)
            {
                number = 7;
            }
            else  if (number % 6 == 0)
            {
                number = 6;
            }
            else  if (number % 3 == 0)
            {
                number = 3;
            }
            else  if (number % 2 == 0)
            {
                number = 2;
            }
            else
            {
                isFound = false;
            }

            if (isFound)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}