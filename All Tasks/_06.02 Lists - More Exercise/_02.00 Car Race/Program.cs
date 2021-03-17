using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._00_Car_Race
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double leftSum = 0.0;
            double rightSum = 0.0;

            for (int j = 0; j < numbers.Count / 2; j++)
            {
                int currentNumber = numbers[j];

                if (currentNumber == 0)
                {
                    leftSum *= 0.8;
                }
                else
                {
                    leftSum += currentNumber;
                }
            }

            for (int k = numbers.Count - 1; k > numbers.Count / 2 ; k--)
            {
                int currentNumber = numbers[k];

                if (currentNumber == 0)
                {
                    rightSum *= 0.8;
                }
                else
                {
                    rightSum += currentNumber;
                }
            }

            Console.WriteLine(leftSum <= rightSum ? $"The winner is left with total time: {leftSum}" : $"The winner is right with total time: {rightSum}");
        }
    }
}