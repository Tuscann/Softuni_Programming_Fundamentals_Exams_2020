using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_House_Party
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split().ToArray();

                string name = current[0];
                
                bool isFound = names.Contains(name);

                if (current.Length == 3)
                {
                    if (!isFound)
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (current.Length == 4)
                {
                    if (!isFound)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        names.Remove(name);
                    }
                }
            }
            Console.WriteLine(String.Join(" \n",names));
        }
    }
}