using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._00_Randomize_Words
{
    class Program
    {
        static void Main()
        {
           
            List<string> input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}