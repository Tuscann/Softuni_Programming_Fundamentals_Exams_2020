using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._00_Change_List
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] commands = input.Split().ToArray();
                int element = int.Parse(commands[1]);

                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index,element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}