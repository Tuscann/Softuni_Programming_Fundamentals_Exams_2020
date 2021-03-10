using System;

namespace _11._00_Math_operations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double number = Calculate(firstNumber, command, secondNumber);

            Console.WriteLine($"{number:f0}");
        }

        private static double Calculate(int firstNumber, string command, int secondNumber)
        {
            double sum = 0;

            if (command == "-")
            {
                sum = firstNumber - secondNumber;
            }
            else if (command == "+")
            {
                sum = firstNumber +secondNumber;
            }
            else if (command == "*")
            {
                sum = firstNumber * secondNumber;
            }
            else if (command == "/")
            {
                sum = firstNumber / secondNumber;
            }

            return sum;
        }
    }
}