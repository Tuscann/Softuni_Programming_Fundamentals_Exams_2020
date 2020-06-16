using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Shoot_for_the_Win
{
    class Program
    {
        static void Main()
        {
            List<int> targetSequence = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();

            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command is "End")
                {
                    Console.Write($"Shot targets: {counter} ->");
                    foreach (var t in targetSequence)
                    {
                        Console.Write(" " + t);
                    }
                    break;
                }

                int position = int.Parse(command);
                int currentShot;

                if (position < targetSequence.Count)
                {
                    for (int i = 0; i < targetSequence.Count; i++)
                    {
                        if (i == position)
                        {
                            currentShot = targetSequence[i];
                            targetSequence[i] = -1;
                            counter += 1;

                            for (int j = 0; j < targetSequence.Count; j++)
                            {
                                if (i != j && targetSequence[j] != -1)
                                {
                                    if (currentShot < targetSequence[j])
                                    {
                                        targetSequence[j] -= currentShot;
                                    }
                                    else
                                    {
                                        targetSequence[j] += currentShot;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
