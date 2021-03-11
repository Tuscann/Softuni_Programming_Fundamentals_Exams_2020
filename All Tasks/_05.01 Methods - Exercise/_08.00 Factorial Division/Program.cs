using System;
namespace _08._00_Factorial_Division
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double sum = CalculateFactorial(firstNumber) / CalculateFactorial(secondNumber);

            Console.WriteLine($"{sum:f2}");
        }

        private static double CalculateFactorial(long n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}