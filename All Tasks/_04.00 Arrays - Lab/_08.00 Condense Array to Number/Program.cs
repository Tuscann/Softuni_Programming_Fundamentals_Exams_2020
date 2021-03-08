using System;
using System.Linq;

namespace _08._00_Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int finalResult = 0;
            int firstLength = nums.Length - 1;
            for (int i = 0; i < firstLength; i++)
            {
                int[] modifiedArray = new int[nums.Length - 1];
                for (int j = 0; j < modifiedArray.Length; j++)
                {
                    modifiedArray[j] = nums[j] + nums[j + 1];
                }
                nums = modifiedArray;
                finalResult = modifiedArray[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}