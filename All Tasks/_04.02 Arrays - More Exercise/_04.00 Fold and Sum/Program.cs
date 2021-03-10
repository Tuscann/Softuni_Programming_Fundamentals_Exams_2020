using System;
using System.Linq;

namespace _04._00_Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] topArr = new int[numbers.Length / 2];
            int[] bottomArr = new int[numbers.Length / 2];

            int firstPart = numbers.Length / 4;

            for (int i = firstPart - 1; i >= 0; i--)
            {
                topArr[firstPart - i - 1] = numbers[i];
            }
            for (int i = numbers.Length - 1; i >= 3 * numbers.Length / 4; i--)
            {
                topArr[numbers.Length - 1 - i + numbers.Length / 4] = numbers[i];
            }

            for (int i = firstPart; i < numbers.Length - numbers.Length / 4; i++)
            {
                bottomArr[i - firstPart] = numbers[i];
            }

            for (int i = 0; i < topArr.Length; i++)
            {
                Console.Write(topArr[i] + bottomArr[i] + " ");
            }
        }
    }
}