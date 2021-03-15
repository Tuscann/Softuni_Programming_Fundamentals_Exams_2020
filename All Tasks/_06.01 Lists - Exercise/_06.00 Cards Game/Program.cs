using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._00_Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lenght = first.Capacity;

            for (int i = 0; i < lenght; i++)
            {
                if (first.Count == 0 || second.Count == 0)
                {
                    break;
                }

                if (first[i] > second[i])
                {
                    first.Add(first.First());
                    first.Add(second.First());
                }
                else if (first[i] < second[i])
                {
                    second.Add(second.First());
                    second.Add(first.First());
                }
                first.RemoveAt(i);
                second.RemoveAt(i);
                i--;
            }

            if (first.Count > second.Count)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}