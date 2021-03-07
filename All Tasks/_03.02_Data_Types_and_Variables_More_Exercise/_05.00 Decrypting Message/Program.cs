using System;

namespace _05._00_Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                Console.Write((char)(currentChar + key));
            }
        }
    }
}