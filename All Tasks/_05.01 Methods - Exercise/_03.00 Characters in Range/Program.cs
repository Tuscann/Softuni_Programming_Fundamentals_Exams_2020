using System;

namespace _03._00_Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            printChars(firstChar, secondChar);
        }

        private static void printChars(char firstChar, char secondChar)
        {
            int max = Math.Max(firstChar, secondChar);
            int min = Math.Min(firstChar, secondChar);

            for (int i = min+1; i < max; i++)
            {
                Console.Write($"{(char) i} ");
            }
        }
    }
}