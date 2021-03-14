using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < first.Count; i++)
            {
                if (first[i] < 0)
                {
                    first.RemoveAt(i);
                    i--;
                }
            }

            first.Reverse();
            
            if (first.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.Write(string.Join(" ", first));
            }
        }
    }
}