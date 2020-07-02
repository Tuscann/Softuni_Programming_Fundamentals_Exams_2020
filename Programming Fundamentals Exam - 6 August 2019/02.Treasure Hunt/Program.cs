using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main()
        {
            List<string> myList = Console.ReadLine().Split("|").ToList<string>();

            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                List<string> currentCommand = command.Split().ToList();

                if (currentCommand[0] is "Loot")
                {
                    for (int i = 1; i < currentCommand.Count; i++)
                    {
                        if (myList.Contains(currentCommand[i]) == false)
                        {
                            myList.Insert(0, currentCommand[i]);
                        }
                    }
                }
                else if (currentCommand[0] is "Drop")
                {
                    int index = int.Parse(currentCommand[1]);
                    if (index >= 0 & index < myList.Count)
                    {
                        string lastElement = myList[index];
                        myList.Remove(myList[index]);
                        myList.Add(lastElement);
                    }
                }
                else if (currentCommand[0] is "Steal")
                {
                    int count = int.Parse(currentCommand[1]);

                    if (count > myList.Count)
                    {
                        count = myList.Count;

                    }
                    List<string> newList = new List<string>();
                    for (int i = 0; i < count; i++)
                    {
                        newList.Add(myList[myList.Count - 1]);
                        myList.Remove(myList[myList.Count - 1]);
                    }
                    newList.Reverse();
                    Console.WriteLine(string.Join(", ", newList));
                }
                command = Console.ReadLine();
            }

            if (command is "Yohoho!")
            {
                if (myList.Count == 0)
                {
                    Console.WriteLine($"Failed treasure hunt.");
                }
                else
                {
                    double sum = 0.0;
                    for (int i = 0; i < myList.Count; i++)
                    {
                        sum += myList[i].Count();
                    }
                    double averageGain = sum / myList.Count();
                    Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
                }
            }
        }
    }
}