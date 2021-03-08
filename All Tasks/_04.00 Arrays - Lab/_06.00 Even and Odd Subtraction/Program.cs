using System;
using System.Linq;

namespace _06._00_Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] intArray = input.Split(" ").Select(x => int.Parse(x)).ToArray();

            int sumEven = 0;
            int sumnOdd = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sumEven += intArray[i];
                }
                else
                {
                    sumnOdd += intArray[i];
                }
            }

            Console.WriteLine(sumEven - sumnOdd);
        }
    }
}