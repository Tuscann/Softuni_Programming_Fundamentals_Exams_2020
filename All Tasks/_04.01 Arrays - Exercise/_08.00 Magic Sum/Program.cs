using System;
using System.Linq;

namespace _08._00_Magic_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (currentNumber + nextNumber == sum)
                    {
                        Console.Write($"{currentNumber} {nextNumber}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}