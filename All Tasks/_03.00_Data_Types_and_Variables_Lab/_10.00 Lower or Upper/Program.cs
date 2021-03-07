using System;

namespace _10._00_Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char inputChar = Char.Parse(Console.ReadLine());

            bool result = Char.IsUpper(inputChar);

            if (result)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}