using System;
using System.Linq;

namespace _01._00Train
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine(array.Sum());
        }
    }
}