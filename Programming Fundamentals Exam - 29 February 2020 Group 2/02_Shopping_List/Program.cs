using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Shopping_List
{
    class Program
    {
        static void Main()
        {
            List<string> allItems = Console.ReadLine().Split("!").ToList();

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput is "Go Shopping!")
                {
                    for (int i = 0; i < allItems.Count; i++)
                    {

                        if (i < allItems.Count - 1)
                        {
                            Console.Write(allItems[i] + ", ");
                        }
                        else
                        {
                            Console.Write(allItems[i] );
                        }
                    }
                    break;
                }

                string[] command = commandInput.Split(" ").ToArray();

                string item = command[1];

                if (command[0] is "Urgent")
                {
                    if (!allItems.Contains(item))
                    {
                        allItems.Insert(0, item);
                    }
                }
                else if (command[0] is "Unnecessary")
                {
                    if (allItems.Contains(item))
                    {
                        allItems.Remove(item);
                    }
                }
                else if (command[0] is "Correct")
                {
                    string newItem = command[2];

                    if (allItems.Contains(item))
                    {
                        allItems[allItems.FindIndex(ind => ind.Equals(item))] = newItem;
                    }
                }
                else if (command[0] is "Rearrange")
                {
                    if (allItems.Contains(item))
                    {
                        var x = allItems.Find(x => x.Equals(item));

                        allItems.Remove(x);
                        allItems.Add(x);
                    }
                }
            }
        }
    }
}
