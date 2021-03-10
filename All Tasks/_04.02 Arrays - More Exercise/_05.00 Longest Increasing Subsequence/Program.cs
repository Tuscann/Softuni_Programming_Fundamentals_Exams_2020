﻿using System;
using System.Linq;

namespace _05._00_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] lis = new int[maxLength];
            for (int i = 0; i < lis.Length; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }

            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}