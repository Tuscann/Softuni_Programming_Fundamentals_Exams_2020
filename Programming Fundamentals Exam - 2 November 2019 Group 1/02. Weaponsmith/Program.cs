using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main()
        {
            List<string> parts = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string commandLsist = Console.ReadLine();
                if (commandLsist is "Done")
                {
                    Console.WriteLine($"You crafted {String.Join("", parts)}!");
                    break;
                }
                string[] commands = commandLsist.Split(" ").ToArray();

                if (commands[1] is "Left")
                {
                    int index = int.Parse(commands[2]);
                    if (1 <= index && index < parts.Count())
                    {
                        var current = parts[index];
                        var prev = parts[index - 1];

                        parts[index] = prev;
                        parts[index - 1] = current;
                    }
                }
                else if (commands[1] is "Right")
                {
                    int index = int.Parse(commands[2]);
                    if (index >= 0 && index < parts.Count() - 1)
                    {
                        var current = parts[index];
                        var next = parts[index + 1];

                        parts[index] = next;
                        parts[index + 1] = current;
                    }
                }
                else if (commands[1] is "Even")
                {
                    List<String> even = new List<string>();
                    for (int i = 0; i < parts.Count(); i += 2)
                    {
                        even.Add(parts[i]);
                    }
                    Console.WriteLine(String.Join(" ", even));
                }
                else if (commands[1] is "Odd")
                {
                    List<String> odd = new List<string>();
                    for (int i = 1; i < parts.Count(); i += 2)
                    {
                        odd.Add(parts[i]);
                    }
                    Console.WriteLine(String.Join(" ", odd));
                }
            }
        }
    }
}
