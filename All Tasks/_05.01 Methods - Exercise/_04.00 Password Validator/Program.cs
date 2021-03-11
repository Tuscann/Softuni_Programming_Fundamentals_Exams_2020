using System;
using System.Linq;

namespace _04._00_Password_Validator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            bool checkLenght = CheckLenght(input);
            bool onlyDigitsLetters = CheckForDigitsAndLetters(input);
            bool moreThan2Digits = CheckForMore2Digits(input);

            if (checkLenght && onlyDigitsLetters && moreThan2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckForMore2Digits(string input)
        {
            bool isFound = true;

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }

        private static bool CheckForDigitsAndLetters(string input)
        {
            bool isFound = input.All(c => Char.IsLetterOrDigit(c));

            if (isFound == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            return isFound;
        }

        private static bool CheckLenght(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            Console.WriteLine("Password must be between 6 and 10 characters ");
            return false;
        }
    }
}