using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._00_List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string current = Console.ReadLine();

                if (current == "End")
                {
                    break;
                }

                string[] commands = current.Split().ToArray();

                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[1] == "left")
                {
                    int length = int.Parse(commands[2]);

                    for (int i = 0; i < length; i++)
                    {
                        var first = numbers.First();
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (commands[1] == "right")
                {
                    int lengt = int.Parse(commands[2]);

                    for (int i = 0; i < lengt; i++)
                    {
                        numbers.Insert(0, numbers.Last());
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}