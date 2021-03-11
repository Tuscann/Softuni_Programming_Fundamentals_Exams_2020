using System;

namespace _02._00_Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int count = CountVowels(input);

            Console.WriteLine(count);
        }

        private static int CountVowels(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}