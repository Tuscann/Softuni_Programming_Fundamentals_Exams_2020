using System;

namespace _03._00_Calculations
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "subtract")
            {
                PrintSubtract(firstNumber, secondNumber);
            }
            else if (command == "add")
            {
                PrintAdd(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                PrintMultiply(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                PrintDivide(firstNumber, secondNumber);
            }
        }

        private static void PrintDivide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }

        private static void PrintAdd(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        private static void PrintMultiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void PrintSubtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
    }
}