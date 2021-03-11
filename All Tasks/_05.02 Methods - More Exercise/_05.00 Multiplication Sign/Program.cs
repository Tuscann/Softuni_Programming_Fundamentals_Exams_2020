using System;

namespace _05._00_Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (first < 0 && second > 0 && third > 0 ||
                    first > 0 && second < 0 && third > 0 ||
                    first > 0 && second > 0 && third < 0 ||
                    first < 0 && second < 0 && third < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                } 
            }
        }
    }
}