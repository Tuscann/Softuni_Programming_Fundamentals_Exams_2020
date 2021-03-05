using System;

namespace _07._00_Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int startCapacity = 255;
            int leftCapacity = startCapacity;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters - leftCapacity > 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    leftCapacity -= liters;
                }
            }

            Console.WriteLine(startCapacity - leftCapacity);
        }
    }
}