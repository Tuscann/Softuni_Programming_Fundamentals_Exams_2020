using System;

namespace _02._00_English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(printDigit(number));
        }

        private static string printDigit(int number)
        {
            int lastDigit = number % 10;

            string returnDigit = "";
            if (lastDigit == 1)
            {
                returnDigit = "one";
            }
            else if (lastDigit == 2)
            {
                returnDigit = "two";
            }
            else if (lastDigit == 3)
            {
                returnDigit = "three";
            }
            else if (lastDigit == 4)
            {
                returnDigit = "four";
            }
            else if (lastDigit == 5)
            {
                returnDigit = "five";
            }
            else if (lastDigit == 6)
            {
                returnDigit = "six";
            }
            else if (lastDigit == 7)
            {
                returnDigit = "seven";
            }
            else if (lastDigit == 8)
            {
                returnDigit = "eight";
            }
            else if (lastDigit == 9)
            {
                returnDigit = "nine";
            }
            else if (lastDigit == 0)
            {
                returnDigit = "zero";
            }

            return returnDigit;
        }
    }
}