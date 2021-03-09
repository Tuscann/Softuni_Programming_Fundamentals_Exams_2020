using System;
using System.Linq;

namespace _06._00_Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = false;
            int index = 0;

            for (int currentElement = 0; currentElement < array.Length; currentElement++)
            {
                int leftSum = 0;
                for (int j = currentElement - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int j = currentElement + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.WriteLine(currentElement);
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}