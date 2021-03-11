using System;

namespace _05._00_Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = CalculateSubtract(CalculateSum(first, second), third);

            Console.WriteLine(sum);
        }

        private static int CalculateSubtract(int sum, int third)
        {
            return sum - third;
        }

        private static int CalculateSum(int first, int second)
        {
            return first + second;
        }
    }
}