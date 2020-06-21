using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Inventory
{
    class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string commandsList = Console.ReadLine();

                if (commandsList is "Craft!")
                {
                    break;
                }
                string[] commands = commandsList.Split(" - ").ToArray();

                string currentCommand = commands[0];

                if (currentCommand is "Collect")
                {
                    bool isCointain = items.Contains(commands[1]);

                    if (isCointain == false)
                    {
                        items.Add(commands[1]);
                    }
                }
                else if (currentCommand is "Drop")
                {
                    bool isCointain = items.Contains(commands[1]);

                    if (isCointain)
                    {
                        items.Remove(commands[1]);
                    }
                }
                else if (currentCommand is "Combine Items")
                {
                    string[] currentItems = commands[1].Split(":");

                    string oldItem = currentItems[0];
                    string newItem = currentItems[1];

                    bool isCointain = items.Contains(oldItem);

                    if (isCointain)
                    {
                        var index = items.IndexOf(oldItem);
                        items.Insert(index + 1, newItem);
                    }
                }
                else if (currentCommand is "Renew")
                {
                    bool isCointain = items.Contains(commands[1]);

                    if (isCointain)
                    {
                        items.Remove(commands[1]);
                        items.Add(commands[1]);
                    }
                }
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (i < items.Count - 1)
                {
                    Console.Write(items[i] + ", ");
                }
                else
                {
                    Console.Write(items[i]);
                }
            }
        }
    }
}
