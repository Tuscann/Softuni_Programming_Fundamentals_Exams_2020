using System;

namespace _09._00_Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }

            int yield = number;

            int counter = 0;
            int totalSpice = 0;

            while (true)
            {
                counter++;
                number -= 26;
                totalSpice += number;
                yield -= 10;

                if (yield < 100)
                {
                    totalSpice -= 26;
                    break;
                }

                number = yield;
            }
            Console.WriteLine(counter);
            Console.Write(totalSpice);
        }
    }
}