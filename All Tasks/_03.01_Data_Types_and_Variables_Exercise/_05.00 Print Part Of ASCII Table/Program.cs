using System;

namespace _05._00_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int currentChar = startChar; currentChar <= endChar; currentChar++)
            {
                Console.Write((char)currentChar+" ");
            }
        }
    }
}