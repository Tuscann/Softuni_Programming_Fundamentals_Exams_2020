﻿using System;

namespace _04._00_Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sum += currentChar;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}