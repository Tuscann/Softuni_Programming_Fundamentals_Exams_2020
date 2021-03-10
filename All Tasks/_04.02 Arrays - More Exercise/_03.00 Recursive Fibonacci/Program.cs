using System;

namespace _03._00_Recursive_Fibonacci
{
    class Program
    {
        private static int Fib(int n1)
        {
            if (n1 <= 2)
                return 1;
            return Fib(n1 - 1) + Fib(n1 - 2);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }
    }
}