using System;

namespace _04._00_Reverse_String
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            name = new string(charArray);

            Console.WriteLine(name);
        }
    }
}