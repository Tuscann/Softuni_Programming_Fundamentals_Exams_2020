using System;
using System.Linq;

namespace _04._00_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] intArray = Console.ReadLine().Split(" ").ToArray();

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.Write(intArray[i]+" ");
            }
        }
    }
}