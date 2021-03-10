using System;

namespace _08._00_Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double newPower = Calculate(number, power);

            Console.WriteLine(newPower);
        }

        private static double Calculate(double number, double power)
        {
            double sum = 1;

            for (int i = 0; i < power; i++)
            {
                sum *= number;
            }

            return sum;
        }
    }
}