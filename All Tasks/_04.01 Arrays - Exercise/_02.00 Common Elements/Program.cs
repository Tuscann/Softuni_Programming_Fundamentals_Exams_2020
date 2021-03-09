using System;
using System.Linq;

namespace _02._00_Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            string[] repeat = new string[firstArray.Length];
            int counter = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        repeat[counter] = firstArray[i];
                        counter++;
                    }
                }
            }

            for (int i = 0; i < repeat.Length; i++)
            {
                if (repeat[i] != null)
                {
                    Console.Write(repeat[i]+" ");
                }
            }
        }
    }
}