using System;

namespace _07._00_Repeat_String
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            int repetition = int.Parse(Console.ReadLine());

            string newString = MakeString(inputString, repetition);

            Console.WriteLine(newString);
        }

        private static string MakeString(string inputString, int repetition)
        {
            string returnString = "";

            for (int i = 0; i < repetition; i++)
            {
                returnString += inputString;
            }

            return returnString;
        }
    }
}