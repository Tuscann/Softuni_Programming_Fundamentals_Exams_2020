using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._01_Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            IEnumerable<string> intersect = firstArray.Intersect(secondArray);

            foreach (string value in intersect)
            {
                Console.Write(value + " ");
            }
        }
    }
}