using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Archery_Tournament
{
    class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            int count = 0;

            while (true)
            {
                string inputs = Console.ReadLine();
                if (inputs is "Game over")
                {
                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (i < targets.Count - 1)
                        {
                            Console.Write(targets[i] + " - ");
                        }
                        else
                        {
                            Console.WriteLine(targets[i]);
                        }
                    }

                    Console.WriteLine($"Iskren finished the archery tournament with {count} points!");
                    break;
                }
                if (inputs is "Reverse")
                {
                    targets.Reverse();
                }
                else
                {
                    string[] commands = inputs.Split("@").ToArray();

                    int startIndex = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    if (commands[0] is "Shoot Left" && 0 <= startIndex && startIndex < targets.Count)
                    {
                        int targetIndex = startIndex - length;

                        while (targetIndex < 0)
                        {
                            targetIndex = targets.Count + targetIndex;
                        }
                        if (targets[targetIndex] >= 5)
                        {
                            targets[targetIndex] -= 5;
                            count += 5;
                        }
                        else
                        {
                            count += targets[targetIndex];
                            targets[targetIndex] = 0;
                        }
                    }
                    else if (commands[0] is "Shoot Right" && startIndex >= 0 && startIndex < targets.Count)
                    {
                        int targetIndex = startIndex + length;

                        while (targetIndex >= targets.Count)
                        {
                            targetIndex = targetIndex - targets.Count;
                        }
                        if (targets[targetIndex] >= 5)
                        {
                            targets[targetIndex] -= 5;
                            count += 5;
                        }
                        else
                        {
                            count += targets[targetIndex];
                            targets[targetIndex] = 0;
                        }
                    }
                }
            }
        }
    }
}
