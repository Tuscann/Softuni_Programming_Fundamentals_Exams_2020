using System;
using System.Linq;

namespace _03._00_Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            double[] intArray = input.Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == 0)
                {
                    intArray[i] = 0;
                }

                Console.WriteLine("{0} => {1}", intArray[i], (int) Math.Round(intArray[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}