using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._00_Gauss_Trick
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < list.Count / 2; i++)
            {
                int first = list.First();
                int last = list.Last();

                Console.Write(first + last + " ");
                list.RemoveAt(0);
                list.RemoveAt(list.Count - 1);
                i--;
            }


            if (list.Count % 2 != 0)
            {
                Console.Write(list.First());
            }
        }
    }
}