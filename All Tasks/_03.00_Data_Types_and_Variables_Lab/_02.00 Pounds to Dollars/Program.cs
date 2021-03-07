using System;

namespace _02._00_Pounds_to_Dollars
{
    class Program
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{number * 1.31M:F3}");
        }
    }
}