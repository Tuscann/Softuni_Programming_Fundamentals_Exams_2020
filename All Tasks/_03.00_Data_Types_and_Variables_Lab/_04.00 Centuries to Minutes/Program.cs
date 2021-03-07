using System;

namespace _04._00_Centuries_to_Minutes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int years = 100 * n;
            int days = (int)(years * 365.2422);
            long hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}