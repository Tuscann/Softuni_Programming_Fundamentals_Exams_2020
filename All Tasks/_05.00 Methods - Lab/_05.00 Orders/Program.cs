using System;

namespace _05._00_Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            printCalculatedMoney(product, count);
        }

        private static void printCalculatedMoney(string product, int count)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = 1.5;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else if (product == "snacks")
            {
                price = 2;
            }

            Console.WriteLine($"{count * price:f2}");
        }
    }
}