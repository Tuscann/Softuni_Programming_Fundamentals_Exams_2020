using System;

namespace _01._00_Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            int sum = (first + second) /third * four;

            Console.WriteLine(sum);
        }
    }
}