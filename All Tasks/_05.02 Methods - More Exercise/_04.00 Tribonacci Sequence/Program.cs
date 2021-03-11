using System;

namespace _04._00_Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (n == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");

                int first = 1;
                int second = 1;
                int third = 2;

                for (int i = 0; i < n - 3; i++)
                {
                    Console.Write(first + second + third + " ");

                    int temp = first;
                    first = second;
                    second = third;
                    third = first + second + temp;
                }
            }
        }
    }
}