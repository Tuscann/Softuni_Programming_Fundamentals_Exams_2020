using System;

namespace _06._01_Balanced_Brackets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int countOpenBrackets = 0;
            int countClosedBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpenBrackets++;
                }

                if (input == ")")
                {
                    countClosedBrackets++;
                    if (countOpenBrackets - countClosedBrackets != 0)
                    {
                        break;
                    }
                }
            }

            if (countOpenBrackets == countClosedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}