using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Moving_Target
{
    class Program
    {
        static void Main()
        {
            List<int> targetSequence = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input is "End")
                {
                    for (int i = 0; i < targetSequence.Count; i++)
                    {
                        int currentValue = targetSequence[i];

                        if (i == 0 || i == targetSequence.Count)
                        {
                            Console.Write(currentValue);
                        }
                        else
                        {
                            Console.Write("|" + currentValue);
                        }
                    }
                    break;
                }

                List<string> commandInput = input.Split(' ').ToList();

                string command = commandInput[0];
                int index = int.Parse(commandInput[1]);
                int value = int.Parse(commandInput[2]);

                if (command is "Shoot")
                {
                    if (0 <= index && index < targetSequence.Count)
                    {
                        targetSequence[index] -= value;

                        if (targetSequence[index] <= 0)
                        {
                            targetSequence.RemoveAt(index);
                        }
                    }
                }
                else if (command is "Add")
                {
                    if (0 <= index && index < targetSequence.Count)
                    {
                        targetSequence.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command is "Strike")
                {
                    int startIndex = index - value;
                    int endIndex = index + value;

                    if (0 <= startIndex && endIndex < targetSequence.Count - 1)
                    {
                        targetSequence.RemoveRange(startIndex, endIndex - startIndex + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
        }
    }
}
