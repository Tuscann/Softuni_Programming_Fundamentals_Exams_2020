using System;

namespace _04._00_Print_and_sum
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                Console.Write(currentNumber + " ");
                sum += currentNumber;
            }

            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}