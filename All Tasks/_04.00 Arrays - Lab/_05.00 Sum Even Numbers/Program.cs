using System;
using System.Linq;

namespace _05._00_Sum_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] intArray = input.Split(" ").Select(x => int.Parse(x)).ToArray();

            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sum += intArray[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}