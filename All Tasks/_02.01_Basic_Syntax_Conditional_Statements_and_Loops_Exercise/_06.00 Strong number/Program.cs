using System;

namespace _06._00_Strong_number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (isDigitsFactDivByNumber(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool isDigitsFactDivByNumber(int num)
        {
            int factorial(int n)
            {
                if (n == 1 || n == 0)
                    return 1;
                return factorial(n - 1) * n;
            }

            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += factorial(digit);
                num /= 10;
            }

            if (sum % temp == 0)
            {
                return true;
            }

            return false;
        }
    }
}