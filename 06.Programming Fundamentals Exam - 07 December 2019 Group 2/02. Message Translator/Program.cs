using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> guestMenue = new Dictionary<string, List<string>>();
            int count = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command is "Stop")
                {
                    break;
                }

                string[] commandSplit = command.Split("-").ToArray();
                string likeUnlike = commandSplit[0];
                string guests = commandSplit[1];
                string meal = commandSplit[2];

                if (likeUnlike == "Like")
                {
                    if (!guestMenue.ContainsKey(guests))
                    {
                        guestMenue.Add(guests, new List<string> { meal });
                    }
                    else if (!guestMenue[guests].Contains(meal))
                    {
                        guestMenue[guests].Add(meal);
                    }
                }
                else if (likeUnlike == "Unlike")
                {
                    if (!guestMenue.ContainsKey(guests))
                    {
                        Console.WriteLine($"{guests} is not at the party.");

                    }
                    else if (!guestMenue[guests].Contains(meal))
                    {
                        Console.WriteLine($"{guests} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        guestMenue[guests].Remove(meal);
                        Console.WriteLine($"{guests} doesn't like the {meal}.");
                        count++;
                    }
                }
            }

            foreach (var kvp in guestMenue.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
