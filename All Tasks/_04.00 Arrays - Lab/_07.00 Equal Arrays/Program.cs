using System;
using System.Linq;

namespace _07._00_Equal_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isIdentical = true;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                sum += firstArray[i];
            }

            if (isIdentical)
            {
                Console.Write($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}