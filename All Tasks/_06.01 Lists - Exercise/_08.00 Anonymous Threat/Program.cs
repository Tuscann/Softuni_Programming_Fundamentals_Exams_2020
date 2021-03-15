using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._00_Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "3:1")
                {
                    break;
                }

                List<string> commands = input.Split().ToList();

                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    string merged = string.Empty;

                    if (startIndex < 0 || startIndex >= names.Count)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= names.Count || endIndex < 0)
                    {
                        endIndex = names.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged += names[startIndex];
                        names.RemoveAt(startIndex);
                    }

                    names.Insert(startIndex, merged);
                }
                else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                    string element = names[index];
                    names.RemoveAt(index);

                    int partitionSize = element.Length / partitions;

                    List<string> subStrings = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string subString = element.Substring(i * partitionSize, partitionSize);
                        subStrings.Add(subString);
                    }

                    string lastSubstring = element.Substring((partitions - 1) * partitionSize);
                    subStrings.Add(lastSubstring);

                    names.InsertRange(index, subStrings);
                }
            }

            Console.WriteLine(String.Join(" ", names));
        }
    }
}