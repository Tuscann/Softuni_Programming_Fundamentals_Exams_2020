using System;
using System.Linq;

namespace _03._00_Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] firstArray = new string[number];
            string[] secondArray = new string[number];

            for (int i = 1; i <= number; i++)
            {
                string[] current = Console.ReadLine().Split().ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i - 1] = current[1];
                    secondArray[i - 1] = current[0];
                }
                else
                {
                    firstArray[i - 1] = current[0];
                    secondArray[i - 1] = current[1];
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
        }
    }
}