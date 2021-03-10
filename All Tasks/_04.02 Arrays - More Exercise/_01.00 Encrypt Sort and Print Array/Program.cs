using System;
using System.Linq;

namespace _01._00_Encrypt_Sort_and_Print_Array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                string input = Console.ReadLine();

                char[] currentChar = input.ToCharArray();

                for (int j = 0; j < currentChar.Length; j++)
                {
                    if (vowels.Contains(currentChar[j]))
                    {
                        sum += currentChar[j] * currentChar.Length;
                    }
                    else
                    {
                        sum += currentChar[j] / currentChar.Length;
                    }
                }

                array[i] = sum;
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}