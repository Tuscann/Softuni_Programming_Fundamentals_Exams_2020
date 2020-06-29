using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();

            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;

            while (true)
            {
                string commandList = Console.ReadLine();
                if (commandList is "Report")
                {

                    for (int i = 0; i < names.Count(); i++)
                    {
                        if (names[i] is "Blacklisted")
                        {
                            blacklistedNamesCount++;
                        }
                        if (names[i] is "Lost")
                        {
                            lostNamesCount++;
                        }
                    }
                    Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
                    Console.WriteLine($"Lost names: {lostNamesCount}");
                    names.ForEach(s => Console.Write(s + " "));

                    break;
                }

                string[] commands = commandList.Split(" ").ToArray();

                if (commands[0] is "Blacklist")
                {
                    string searchedName = commands[1];

                    if (names.Contains(searchedName))
                    {
                        Console.WriteLine($"{searchedName} was blacklisted.");
                        int index = names.IndexOf(searchedName);

                        names[index] = "Blacklisted";
                    }
                    else
                    {
                        Console.WriteLine($"{searchedName} was not found.");
                    }
                }
                else if (commands[0] is "Error")
                {
                    int index = int.Parse(commands[1]);

                    if (names[index] is "Blacklisted" || names[index] is "Lost")
                    {

                    }
                    else
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names[index] = "Lost";
                    }
                }
                else if (commands[0] is "Change")
                {
                    int index = int.Parse(commands[1]);
                    string newName = commands[2];

                    if (index >= 0 && index < names.Count())
                    {
                        Console.WriteLine($"{names[index]} changed his username to {newName}.");

                        names[index] = newName;
                    }
                }
            }
        }
    }
}
