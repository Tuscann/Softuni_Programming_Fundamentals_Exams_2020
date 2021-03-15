using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._00_Train
{
    class Program
    {
        static void Main()
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] commands = input.Split().ToArray();

                if (commands[0] == "Add")
                {
                    train.Add(int.Parse(commands[1]));
                }
                else
                {
                    int passengersToAdd = int.Parse(commands[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagon = train[i];

                        if (currentWagon + passengersToAdd <= maxCapacity)
                        {
                            train[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}