using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<long>> hereous = new Dictionary<string, List<long>>();
            
            for (int i = 0; i < n; i++)
            {
                List<string> herou = Console.ReadLine().Split(" ").ToList();

                List<long> listlLongs = new List<long>();
                listlLongs.Add(int.Parse(herou[1]));
                listlLongs.Add(int.Parse(herou[2]));

                hereous.Add(herou[0], listlLongs);
            }

            while (true)
            {
                string inputs = Console.ReadLine();

                if (inputs is "End")
                {
                    var sortedCollection = hereous.OrderByDescending(m => m.Value[0]).ThenBy(n => n.Key);

                    foreach ((string name, List<long> meals) in sortedCollection)
                    {
                        Console.WriteLine($"{name}");
                        Console.WriteLine($"  HP: {meals[0]}\n  MP: {meals[1]}");
                    }
                    break;
                }
                List<string> commands = inputs.Split(" - ").ToList();

                string command = commands[0];
                string heroName = commands[1];

                var currentHeroes = hereous[heroName];

                if (command is "CastSpell")
                {
                    long manaPoints = int.Parse(commands[2]);
                    string spellName = commands[3];

                    if (currentHeroes[1] - manaPoints >= 0)
                    {
                        currentHeroes[1] -= manaPoints;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {currentHeroes[1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command is "TakeDamage")
                {
                    long damage = int.Parse(commands[2]);
                    string attacker = commands[3];

                    if (currentHeroes[0] - damage > 0)
                    {
                        currentHeroes[0] -= damage;

                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currentHeroes[0]} HP left!");
                    }
                    else
                    {
                        hereous.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (command is "Recharge")
                {
                    long amount = int.Parse(commands[2]);

                    long beforeMana = currentHeroes[1];

                    currentHeroes[1] += amount;

                    if (currentHeroes[1] >= 200)
                    {
                        currentHeroes[1] = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for { currentHeroes[1] - beforeMana} MP!");
                }
                else if (command is "Heal")
                {
                    long amount = int.Parse(commands[2]);

                    long beforeHP = currentHeroes[0];

                    currentHeroes[0] += amount;
                    
                    if (currentHeroes[0] >= 100)
                    {
                        currentHeroes[0] = 100;
                    }
                    Console.WriteLine($"{heroName} healed for { currentHeroes[0] - beforeHP} HP!");
                }
            }
        }
    }
}
