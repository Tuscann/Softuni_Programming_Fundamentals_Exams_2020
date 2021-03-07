using System;

namespace _07._00_Concat_Names
{
    class Program
    {
        static void Main()
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string thirdChar = Console.ReadLine();

            Console.WriteLine($"{firstChar}{thirdChar}{secondChar}"); 
        }
    }
}