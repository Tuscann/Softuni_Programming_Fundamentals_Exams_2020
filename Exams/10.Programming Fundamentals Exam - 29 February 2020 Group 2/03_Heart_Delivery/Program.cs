using System;
using System.Linq;

namespace _03_Heart_Delivery
{
    class Program
    {
        static void Main()
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            int currentPosition = 0;

            while (true)
            {
                string commandList = Console.ReadLine();

                if (commandList == "Love!")
                {
                    Console.WriteLine($"Cupid's last position was {currentPosition}.");
                    
                    bool isSuccessful = houses.All(t => t == 0);
                    
                    if (isSuccessful)
                    {
                        Console.WriteLine("Mission was successful.");
                    }
                    else
                    {
                        int count = houses.Count(t => t != 0);
                        Console.WriteLine($"Cupid has failed {count} places.");
                    }
                    break;
                }

                if (commandList.StartsWith("Jump"))
                {
                    string[] str = commandList.Split(" ").ToArray();

                    int position = int.Parse(str[1]);
                    currentPosition += position;

                    if (currentPosition >= houses.Length)
                    {
                        currentPosition = 0;
                    }

                    for (int i = 0; i < houses.Length; i++)
                    {
                        if (currentPosition == i)
                        {
                            if (houses[i] == 0)
                            {
                                Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                            }
                            else
                            {
                                houses[i] -= 2;

                                if (houses[i] == 0)
                                {
                                    Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
