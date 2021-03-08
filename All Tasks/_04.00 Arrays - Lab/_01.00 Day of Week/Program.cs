using System;

namespace _01._00_Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int currentDay = int.Parse(Console.ReadLine());

            if (currentDay >= 1 && currentDay <= 7)
            {
                Console.WriteLine(days[currentDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}