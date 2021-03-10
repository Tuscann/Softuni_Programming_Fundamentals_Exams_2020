using System;

namespace _04._00_Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Print(i);
            }

            for (int i = number - 1; i >= 0; i--)
            {
                Print(i);
            }
        }

        private static void Print(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}