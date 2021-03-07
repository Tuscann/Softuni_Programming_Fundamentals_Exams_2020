using System;

namespace _12._00_Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            for (int num = 1; num <= number; num++)
            {
                int digits = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }

                bool isFound = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine("{0} -> {1}", digits, isFound);
                sumOfDigits = 0;
                num = digits;
            }
        }
    }
}