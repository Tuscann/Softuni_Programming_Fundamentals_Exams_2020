using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._00_Append_Arrays
{
    class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split("|").ToList();

            List<string> returnList = new List<string>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                returnList.AddRange( list[i].Split(" ",StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(" ",returnList));
        }
    }
}