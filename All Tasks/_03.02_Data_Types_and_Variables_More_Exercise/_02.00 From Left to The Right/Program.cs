using System;
using System.Numerics;

namespace _02._00_From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] words = Console.ReadLine().Split(' ');

                BigInteger leftNumber = BigInteger.Parse(words[0]);
                BigInteger rightNumber = BigInteger.Parse(words[1]);

                if (leftNumber > rightNumber)
                {
                    Console.WriteLine(CalculateSum(leftNumber));
                }
                else
                {
                    Console.WriteLine(CalculateSum(rightNumber));
                }
            }
        }

        static BigInteger CalculateSum(BigInteger number)
        {
            BigInteger sum = 0;
            while (number != 0) {
                sum += BigInteger.Abs(number) % 10;
                number /= 10;
            }
            return sum;
        }
    }
}