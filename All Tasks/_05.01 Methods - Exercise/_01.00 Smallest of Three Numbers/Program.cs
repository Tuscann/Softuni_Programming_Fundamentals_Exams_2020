using System;

namespace _01._00_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSmallestNumber(first, second, third));
        }

        private static int FindSmallestNumber(int first, int second, int third)
        {
            int[] array = new int[3] {first, second, third};

            Array.Sort(array);

            return array[0];
        }
    }
}