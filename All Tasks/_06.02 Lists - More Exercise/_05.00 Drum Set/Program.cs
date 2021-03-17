using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Drum_Set
{
    class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> initialDrumQuality = new List<int>(drumSet);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if (drumSet[i] <= 0)
                    {
                        double price = initialDrumQuality[i] * 3.0;
                        if (savings >= price)
                        {
                            drumSet[i] = initialDrumQuality[i];
                            savings -= price;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            initialDrumQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}