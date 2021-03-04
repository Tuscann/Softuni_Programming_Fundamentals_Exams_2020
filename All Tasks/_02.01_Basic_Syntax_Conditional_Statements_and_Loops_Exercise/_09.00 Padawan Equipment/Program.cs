using System;

namespace _09._00_Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            double amountMoney = Double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = Double.Parse(Console.ReadLine());
            double priceRobes = Double.Parse(Console.ReadLine());
            double priceBelts = Double.Parse(Console.ReadLine());

            double priceBeltsTotal = priceBelts * countStudents;

            if (countStudents / 6 >= 1)
            {
                priceBeltsTotal = priceBelts * (countStudents - countStudents / 6);
            }

            double totalMoney = priceLightsabers * Math.Ceiling(countStudents * 1.1)
                                + priceRobes * countStudents
                                + priceBeltsTotal;

            if (totalMoney > amountMoney)
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - amountMoney:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
        }
    }
}