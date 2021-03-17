using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._00_Messaging
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string message = Console.ReadLine();
            string result = string.Empty;

            foreach (int number in numbers)
            {
                string num = number.ToString();
                int index = 0;
                for (int index1 = 0; index1 < num.Length; index1++)
                {
                    index += num[index1] - '0';
                }

                while (index >= message.Length)
                {
                    index -= message.Length;
                }

                result += message[index];
                message = message.Remove(index, 1);
            }

            Console.WriteLine(result);
        }
    }
}