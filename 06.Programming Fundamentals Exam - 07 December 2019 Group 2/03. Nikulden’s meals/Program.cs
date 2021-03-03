using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main()
        {
            List<int> roses = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x.Trim()))
                .ToList();

            roses.Reverse();

            List<int> lilies = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x.Trim()))
                .ToList();


            int countwreath = 0;
            int flowers = 0;
            int lenght = roses.Count;

            for (int i = 0; i < lenght; i++)
            {
                if (roses.Count == 0 || lilies.Count == 0)
                {
                    break;
                }

                if (roses[i] + lilies[i] == 15)
                {
                    roses.RemoveAt(i);
                    lilies.RemoveAt(i);
                    i--;
                    lenght -= 1;
                    countwreath += 1;
                }
                else if (roses[i] + lilies[i] > 15)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        if (roses[i] + lilies[i] > 15)
                        {
                            roses[i] -= 2;
                        }
                        else if (roses[i] + lilies[i] == 15)
                        {
                            roses.RemoveAt(i);
                            lilies.RemoveAt(i);
                            i--;
                            lenght -= 1;
                            countwreath += 1;
                            break;
                        }
                        else if (roses[i] + lilies[i] < 15)
                        {
                            flowers += roses[i] + lilies[i];
                            roses.RemoveAt(i);
                            lilies.RemoveAt(i);
                            i--;
                            lenght -= 1;
                            break;
                        }
                    }
                }
                else if (roses[i] + lilies[i] < 15)
                {
                    flowers += roses[i] + lilies[i];
                    roses.RemoveAt(i);
                    lilies.RemoveAt(i);
                    i--;
                    lenght -= 1;
                }
            }

            if (flowers / 15 > 0)
            {
                countwreath += flowers / 15;
            }

            if (countwreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {countwreath} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - countwreath} wreaths more!");
            }
        }
    }
}
