using System;

namespace _04._00_Refactoring_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int delitel = 2; delitel < currentNumber; delitel++)
                {
                    if (currentNumber % delitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", currentNumber); 
                }
                else
                {
                    Console.WriteLine("{0} -> false", currentNumber); 
                }
            }
        }
    }
}