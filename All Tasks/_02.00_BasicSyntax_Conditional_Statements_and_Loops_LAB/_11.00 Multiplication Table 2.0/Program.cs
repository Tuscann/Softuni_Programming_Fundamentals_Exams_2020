using System;

namespace _11._00_Multiplication_Table_2._0
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                } 
            }
        }
    }
}