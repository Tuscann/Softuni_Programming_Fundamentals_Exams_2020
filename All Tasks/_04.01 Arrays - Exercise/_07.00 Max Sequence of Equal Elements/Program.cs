using System;
using System.Linq;

namespace _07._00_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int sequenceSize = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];

                    if (currentNumber == rightNumber)
                    {
                        sequenceSize++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceNumber = currentNumber;
                    bestSequenceSize = sequenceSize;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write(bestSequenceNumber + " ");
            }
        }
    }
}