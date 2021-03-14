using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._00_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        numbers[j] += numbers[j + 1];
                        numbers.RemoveAt(j + 1);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}