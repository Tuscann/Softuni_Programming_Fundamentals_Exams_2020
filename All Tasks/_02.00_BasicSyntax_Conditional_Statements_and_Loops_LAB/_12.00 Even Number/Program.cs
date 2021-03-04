using System;

namespace _12._00_Even_Number
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (Math.Abs(number) % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}