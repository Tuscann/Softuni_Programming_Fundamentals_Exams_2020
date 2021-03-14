using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_Merging_Lists
{
    class Program
    {
        static void Main()
        {
            List<double> first = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> second = Console.ReadLine().Split().Select(double.Parse).ToList();
            
            List<double> result = new List<double>(first.Count + second.Count);

            for (int i = 1; i <= result.Capacity; i++)
            {
                if (i % 2 == 0)
                {
                    if (second.Count != 0)
                    {
                        result.Add(second.First());
                        second.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(first.First());
                        first.RemoveAt(0);
                    }
                }
                else
                {
                    if (first.Count != 0)
                    {
                        result.Add(first.First());
                        first.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(second.First());
                        second.RemoveAt(0);
                    }
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}