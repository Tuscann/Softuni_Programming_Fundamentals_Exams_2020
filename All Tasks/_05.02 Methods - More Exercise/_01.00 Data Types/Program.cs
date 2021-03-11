using System;

namespace _01._00_Data_Types
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string number = Console.ReadLine();

            if (input == "int")
            {
                Calculate(int.Parse(number));
            }
            else if (input == "real")
            {
                Calculate(double.Parse(number));
            }
            else if (input == "string")
            {
                Calculate(number);
            }
        }

        private static void Calculate(int number)
        {
            Console.WriteLine(number * 2);
        }

        private static void Calculate(double number)
        {
            Console.WriteLine($"{number * 1.5:f2}");
        }

        private static void Calculate(string stringInput)
        {
            Console.WriteLine($"${stringInput}$");
        }
    }
}