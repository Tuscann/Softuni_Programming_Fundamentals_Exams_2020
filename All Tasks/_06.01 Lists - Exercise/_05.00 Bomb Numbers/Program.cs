using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] current = Console.ReadLine().Split().ToArray();

            int bobNumber = int.Parse(current[0]);
            int bombPower = int.Parse(current[1]);

            while (true)
            {
                int indexOfBombNumber = numbers.IndexOf(bobNumber);

                if (indexOfBombNumber == -1)
                {
                    break;
                }

                int startIndex = indexOfBombNumber - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int count = 2 * bombPower + 1;

                if (count > numbers.Count - startIndex)
                {
                    count = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, count);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}