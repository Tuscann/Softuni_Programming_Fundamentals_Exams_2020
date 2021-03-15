using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._00_Pokemon_Do_not_Go
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (true)
            {
                if (numbers.Count == 0)
                {
                    break;
                }

                int index = int.Parse(Console.ReadLine());

                int removed;

                if (index < 0)
                {
                    index = 0;

                    removed = numbers[index];
                    numbers.RemoveAt(index);
                    numbers.Insert(0, numbers.Last());
                }
                else if (index > numbers.Count - 1)
                {
                    index = numbers.Count - 1;
                    
                    removed = numbers[index];
                    numbers.RemoveAt(index);
                    numbers.Add(numbers.First());
                }
                else
                {
                    removed = numbers[index];
                    numbers.RemoveAt(index);
                }

                sum += removed;
                IncreaseOrDecreaseElements(numbers, removed);
            }

            Console.WriteLine(sum);
        }

        public static void IncreaseOrDecreaseElements(List<int> numbers, int removed)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= removed)
                {
                    numbers[i] += removed;
                }
                else
                {
                    numbers[i] -= removed;
                }
            }
        }
    }
}