using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Followers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> peshosFollowers = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Log out")
                {
                    break;
                }

                string[] commands = input.Split(": ");

                string command = commands[0];

                if (command is "New follower")
                {
                    string username = commands[1];

                    if (!peshosFollowers.ContainsKey(username))
                    {
                        peshosFollowers.Add(username, new List<int>() { 0, 0 });
                    }
                }
                else if (command is "Like")
                {
                    string username = commands[1];
                    int likesCount = int.Parse(commands[2]);

                    if (!peshosFollowers.ContainsKey(username))
                    {
                        peshosFollowers.Add(username, new List<int>() { 0, 0 });
                    }

                    peshosFollowers[username][0] += likesCount;
                }
                else if (command is "Comment")
                {
                    string username = commands[1];

                    if (!peshosFollowers.ContainsKey(username))
                    {
                        peshosFollowers.Add(username, new List<int>() { 0, 0 });
                    }
                    peshosFollowers[username][1] += 1;

                }
                else if (command is "Blocked")
                {
                    string username = commands[1];

                    if (peshosFollowers.ContainsKey(username))
                    {
                        peshosFollowers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
            }

            Console.WriteLine($"{peshosFollowers.Count} followers");

            var sortedCollection = peshosFollowers.OrderByDescending(m => m.Value[0]).ThenBy(key => key.Key);

            foreach ((string key, List<int> values) in sortedCollection)
            {
                Console.WriteLine($"{key}: {values[0] + values[1]}");
            }
        }
    }
}
