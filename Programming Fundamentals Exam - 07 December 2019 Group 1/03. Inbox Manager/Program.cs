using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> people = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input is "Statistics")
                {
                    IOrderedEnumerable<KeyValuePair<string, List<string>>> sortedCollection = people.OrderByDescending(m => m.Value.Count).ThenBy(m => m.Key);

                    Console.WriteLine($"Users count: {sortedCollection.Count()}");
                    foreach ((string name, List<string> spells) in sortedCollection)
                    {
                        Console.WriteLine($"{name}");
                        for (int i = 0; i < spells.Count; i++)
                        {
                            Console.WriteLine(" - " + spells[i]);
                        }
                    }

                    break;
                }
                string[] commands = input.Split("->").ToArray();

                if (commands[0] is "Add")
                {
                    string username = commands[1];
                    if (people.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        people.Add(username, new List<string>());
                    }
                }
                else if (commands[0] is "Send")
                {
                    string username = commands[1];
                    string email = commands[2];

                    people[username].Add(email);
                }
                else if (commands[0] is "Delete")
                {
                    string username = commands[1];
                    if (people.ContainsKey(username))
                    {
                        people.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }
        }
    }
}
