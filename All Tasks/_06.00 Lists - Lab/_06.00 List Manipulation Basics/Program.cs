using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._00_List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string current = Console.ReadLine();
                if (current == "end")
                {
                    break;
                }

                string[] array = current.Split().ToArray();

                if (array[0] == "Add")
                {
                    first.Add(int.Parse(array[1]));
                }
                else if (array[0] == "Remove")
                {
                    first.Remove(int.Parse(array[1]));
                }
                else if (array[0] == "RemoveAt")
                {
                    first.RemoveAt(int.Parse(array[1]));
                }
                else if (array[0] == "Insert")
                {
                    if (int.Parse(array[2]) < first.Count)
                    {
                        first.Insert(int.Parse(array[2]), int.Parse(array[1]));
                    }
                }
            }

            Console.Write(string.Join(" ", first));
        }
    }
}