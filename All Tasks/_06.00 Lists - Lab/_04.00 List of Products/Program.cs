using System;
using System.Collections.Generic;

namespace _04._00_List_of_Products
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            
            List<string> first = new List<string>(count);
            
            for (int i = 0; i < count; i++)
            {
                first.Add(Console.ReadLine());
            }
            first.Sort((x, y) => x.CompareTo(y));
            for (int i = 0; i < first.Count; i++)
            {
                Console.WriteLine($"{i+1}.{first[i]}");
            }
        }
    }
}