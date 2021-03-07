using System;

namespace _09._00_Chars_to_String
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string outPut = "" + firstChar + secondChar + thirdChar;

            Console.WriteLine(outPut);
        }
    }
}