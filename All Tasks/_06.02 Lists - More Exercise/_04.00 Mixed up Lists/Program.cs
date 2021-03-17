using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._00_Mixed_up_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixesNumbers = new List<int>();

            int min = Math.Min(second[0], second[1]);
            int max = Math.Max(second[0], second[1]);

            if (first.Count > second.Count)
            {
                min = Math.Min(first[first.Count - 1], first[first.Count - 2]);
                max = Math.Max(first[first.Count - 1], first[first.Count - 2]);
            }

            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                mixesNumbers.Add(first[i]);
                mixesNumbers.Add(second[second.Count - 1 - i]);
            }

            List<int> output = mixesNumbers.FindAll(x => min < x && x < max);

            output.Sort();
            Console.WriteLine(string.Join(' ', output));
        }
    }
}