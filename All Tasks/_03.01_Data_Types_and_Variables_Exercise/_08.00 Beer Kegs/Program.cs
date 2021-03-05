using System;

namespace _08._00_Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            double maxVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume >= maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}