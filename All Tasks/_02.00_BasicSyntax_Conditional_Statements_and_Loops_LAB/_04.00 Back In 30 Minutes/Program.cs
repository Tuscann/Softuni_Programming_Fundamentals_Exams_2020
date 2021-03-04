using System;

namespace _04._00_Back_In_30_Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.Write($"{hours}:");

            if (minutes < 10)
            {
                Console.Write($"0");
            }

            Console.Write($"{minutes}");
        }
    }
}