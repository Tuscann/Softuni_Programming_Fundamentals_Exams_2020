using System;

namespace _02._00_Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                int val = 1;
                for (int column = 0; column <= row; column++)
                {
                    if (column == 0 || row == 0)
                    {
                        val = 1; 
                    }
                    else
                    {
                        val = val * (row - column + 1) / column;
                    }
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}