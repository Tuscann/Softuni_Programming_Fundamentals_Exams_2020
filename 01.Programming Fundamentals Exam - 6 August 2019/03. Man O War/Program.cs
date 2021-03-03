using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHelth = int.Parse(Console.ReadLine());

            bool yes = false;

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand is "Retire")
                {
                    break;
                }

                string[] comnd = comand.Split(" ");
                if (comnd[0] is "Fire")
                {
                    int index = int.Parse(comnd[1]);
                    int damage = int.Parse(comnd[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        int afterFire = warShip[index];
                        afterFire = afterFire - damage;
                        if (afterFire <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            yes = true;
                        }
                        else
                        {
                            warShip.RemoveAt(index);
                            warShip.Insert(index, afterFire);
                        }
                    }
                }
                else if (comnd[0] is "Defend")
                {
                    int startIndex = int.Parse(comnd[1]);
                    int endIndex = int.Parse(comnd[2]);
                    int damage = int.Parse(comnd[3]);
                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int indexNumber = i;
                            int result = pirateShip[indexNumber] - damage;
                            if (result <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                yes = true;
                                break;
                            }
                            else
                            {
                                pirateShip.Remove(pirateShip[indexNumber]);
                                pirateShip.Insert(startIndex, result);
                                startIndex++;
                            }
                        }
                    }
                }
                else if (comnd[0] is "Repair")
                {
                    int index = int.Parse(comnd[1]);
                    int helth = int.Parse(comnd[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (helth > maxHelth)
                        {
                            helth = maxHelth;
                        }
                        else
                        {
                            helth += pirateShip[index];
                        }
                        pirateShip.RemoveAt(index);
                        pirateShip.Insert(index, helth);
                    }
                }
                else if (comnd[0] is "Status")
                {
                    int count = 0;
                    double percent = maxHelth * 0.2;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        int one = pirateShip[i];
                        if (percent > one)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
                if (yes)
                {
                    break;
                }
            }
            if (yes == false)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}