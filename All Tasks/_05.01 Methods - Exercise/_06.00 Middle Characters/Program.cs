using System;

namespace _06._00_Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            CalculateMiddle(input);
        }

        private static void CalculateMiddle(string input)
        {
            int lenght = input.Length / 2 ;

            if (input.Length % 2 == 0)
            {
                Console.Write($"{input[lenght-1]}{input[lenght]}");
            }
            else
            {
                Console.WriteLine(input[lenght]);
            }
        }
    }
}