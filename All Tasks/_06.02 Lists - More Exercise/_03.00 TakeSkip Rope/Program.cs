﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_TakeSkip_Rope
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            List<char> nonNumbers = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (48 <= symbol && symbol <= 57)
                {
                    numbers.Add(symbol - '0');
                    input = input.Remove(i, 1);
                    i--;
                }
                else
                {
                    nonNumbers.Add(input[i]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = string.Empty;
            int skip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                result += new string(nonNumbers.Skip(skip).Take(takeList[i]).ToArray());
                skip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result);
        }
    }
}