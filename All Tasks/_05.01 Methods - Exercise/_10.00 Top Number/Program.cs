using System;

namespace _10._00_Top_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                bool isDevide8 = Devide8(i);
                bool isHaveOddNumber = OddNumber(i);

                if (isDevide8 && isHaveOddNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OddNumber(int i)
        {
            int odd_count = 0;
            while (i > 0)
            {
                int rem = i % 10;
                if (rem % 2 != 0)
                    odd_count++;
                i = i / 10;
            }

            if (odd_count > 1)
            {
                return true;
            }

            return false;
        }

        private static bool Devide8(int i)
        {
            int sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}