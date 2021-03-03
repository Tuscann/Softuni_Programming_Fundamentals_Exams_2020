using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_P_rates
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<long>> cities = new Dictionary<string, List<long>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command is "Sail")
                {
                    break;
                }

                string[] city = command.Split("||").ToArray();

                string cityName = city[0];
                int population = int.Parse(city[1]);
                int gold = int.Parse(city[2]);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
                else
                {
                    List<long> currentList = new List<long>();
                    currentList.Add(population);
                    currentList.Add(gold);

                    cities.Add(cityName, currentList);
                }
            }
            while (true)
            {
                string command = Console.ReadLine();

                if (command is "End")
                {
                    break;
                }
                string[] events = command.Split("=>").ToArray();

                string commandName = events[0];
                string townName = events[1];

                List<long> currenttown = cities[townName];

                if (commandName is "Plunder")
                {
                    int people = int.Parse(events[2]);
                    int gold = int.Parse(events[3]);

                    currenttown[0] -= people;
                    currenttown[1] -= gold;

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (currenttown[0] <= 0 || currenttown[1] <= 0)
                    {
                        cities.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }

                }
                else if (commandName is "Prosper")
                {
                    int gold = int.Parse(events[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        currenttown[1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {cities[townName][1]} gold.");
                    }
                }
            }
            var sortedCollection = cities.OrderByDescending(m => m.Value[1]).ThenBy(n => n.Key);
            
            if (cities.Keys.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach ((string city, List<long> meals) in sortedCollection)
                {
                    Console.WriteLine($"{city} -> Population: {meals[0]} citizens, Gold: {meals[1]} kg");
                }
            }
        }
    }
}
