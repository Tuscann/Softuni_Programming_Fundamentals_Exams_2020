using System;
using System.Linq;

namespace _05._00_Top_Integers
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isBigger = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j + 1])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                    }

                    if (isBigger == false)
                    {
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(array[i] + " ");
                }
                isBigger = false;
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}