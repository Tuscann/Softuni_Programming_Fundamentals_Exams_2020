using System;

namespace _03._00_Floating_Equality
{
    class Program
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            bool isEqual = Math.Abs(n1 - n2) < 0.000001;

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}