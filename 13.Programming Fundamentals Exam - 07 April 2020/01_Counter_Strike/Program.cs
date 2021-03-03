using System;

namespace _01_Counter_Strike
{
    class Program
    {
        static void Main()
        {
            long initialEnergy = long.Parse(Console.ReadLine());

            int counter = 0;
            int winBattles = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command is "End of battle")
                {
                    Console.WriteLine($"Won battles: {winBattles}. Energy left: {initialEnergy}");
                    break;
                }

                int number = int.Parse(command);
                counter += 1;

                if (initialEnergy - number >= 0)
                {
                    initialEnergy -= number;
                    winBattles += 1;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winBattles} won battles and {initialEnergy} energy");
                    break;
                }

                if (counter % 3 == 0)
                {
                    initialEnergy += winBattles;
                }
            }
        }
    }
}
