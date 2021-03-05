using System;
using System.Linq;

namespace _02._00_Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = number.ToString().Sum(c => c - '0');

            Console.WriteLine(sum);
        }
    }
}