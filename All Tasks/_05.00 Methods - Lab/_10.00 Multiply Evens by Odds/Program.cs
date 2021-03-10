using System;

namespace _10._00_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            GetMultipleOfEvenAndOdds(GetSumOfOddDigits((number)), GetSumOfEvenDigits(number));
        }

        private static void GetMultipleOfEvenAndOdds(int getSumOfOddDigits, int getSumOfEvenDigits)
        {
            Console.WriteLine(getSumOfEvenDigits * getSumOfOddDigits);
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sumOfEvens = 0;
            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 0)
                {
                    sumOfEvens += nextNum;
                }

                num -= nextNum;
                num /= 10;
            }

            return sumOfEvens;
        }

        private static int GetSumOfOddDigits(int num)
        {
            int sumOfOdds = 0;

            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }

                num -= nextNum;
                num /= 10;
            }

            return sumOfOdds;
        }
    }
}