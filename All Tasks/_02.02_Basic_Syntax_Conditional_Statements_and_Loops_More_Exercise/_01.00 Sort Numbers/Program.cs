using System;

namespace _01._00_Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int[] a = {first, second, third};

            Array.Sort(a);

            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}