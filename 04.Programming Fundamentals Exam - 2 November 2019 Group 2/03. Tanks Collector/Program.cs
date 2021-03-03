using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main()
        {
            List<string> tanksOwned = Console.ReadLine().Split(", ").ToList();
            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(", ");
                string command = tokens[0];

                if (command == "Add")
                {
                    string tankName = tokens[1];
                    if (tanksOwned.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        tanksOwned.Add(tankName);
                    }

                }
                else if (command == "Remove")
                {
                    string name = tokens[1];
                    if (tanksOwned.Contains(name))
                    {
                        Console.WriteLine("Tank successfully sold");
                        tanksOwned.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < tanksOwned.Count)
                    {
                        tanksOwned.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string tankName = tokens[2];
                    if (index >= 0 && index < tanksOwned.Count)
                    {
                        if (tanksOwned.Contains(tankName))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            tanksOwned.Insert(index, tankName);
                            Console.WriteLine("Tank successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", tanksOwned));
        }
    }
}
