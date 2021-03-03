using System;
using System.Linq;

namespace _02_MuOnline
{
    class Program
    {
        static void Main()
        {
            string[] list = Console.ReadLine().Split("|").ToArray();

            int myHealth = 100;
            int bitcoinsSum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                string[] currentRoom = list[i].Split(" ").ToArray();

                if (currentRoom[0] is "potion")
                {
                    int heathBefore = myHealth;
                    myHealth += int.Parse(currentRoom[1]);
                    if (myHealth > 100)
                    {
                        myHealth = 100;
                    }

                    Console.WriteLine($"You healed for {myHealth - heathBefore} hp.");
                    Console.WriteLine($"Current health: {myHealth} hp.");
                }
                else if (currentRoom[0] is "chest")
                {
                    int currentBitcoins = int.Parse(currentRoom[1]);
                    bitcoinsSum += currentBitcoins;
                    Console.WriteLine($"You found {currentBitcoins} bitcoins.");
                }
                else
                {
                    int monsterHealth = int.Parse(currentRoom[1]);

                    myHealth -= monsterHealth;

                    if (myHealth > 0)
                    {
                        Console.WriteLine($"You slayed {currentRoom[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                        Console.WriteLine($"Best room: {i +1}");
                        break;
                    }
                }
            }

            if (myHealth > 0)
            {
                Console.WriteLine($"You've made it! \nBitcoins: {bitcoinsSum} \nHealth: {myHealth}");
            }
        }
    }
}
