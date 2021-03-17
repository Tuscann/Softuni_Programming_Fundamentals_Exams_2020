using System;
using System.Numerics;

namespace _02._00_Big_Factorial
{
    class Program
    {
        static void Main()
        {
            BigInteger factorial = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 2 ; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}