using System;

namespace _09._00_Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reverseString = new string(charArray);

                if (input == reverseString)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}