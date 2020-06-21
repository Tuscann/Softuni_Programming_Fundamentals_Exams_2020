using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Hero_Recruitment
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput is "End")
                {
                    var sortedCollection = heroes.OrderByDescending(m => m.Value.Count).ThenBy(n => n.Key);
                    Console.WriteLine("Heroes:");
                    foreach ((string name, List<string> spells) in sortedCollection)
                    {
                        Console.Write($"== {name}:");
                        for (int i = 0; i < spells.Count; i++)
                        {
                            if (i < spells.Count - 1)
                            {
                                Console.Write(" " + spells[i] + ",");
                            }
                            else
                            {
                                Console.Write(" " + spells[i]);
                            }
                        }

                        Console.WriteLine();
                    }
                    break;
                }

                string[] commands = commandInput.Split(" ").ToArray();
                string heroName = commands[1];

                if (commands[0] is "Enroll")
                {
                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroes[heroName] = new List<string>();
                    }
                }
                else if (commands[0] is "Learn")
                {
                    string spellName = commands[2];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else if (commands[0] is "Unlearn")
                {
                    string spellName = commands[2];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (!heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Remove(spellName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }
        }
    }
}
