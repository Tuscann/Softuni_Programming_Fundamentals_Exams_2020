using System;

namespace _10._00_Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int countTargets = 0;
            int startN = n;

            while (true)
            {
                if (n >= m)
                {
                    countTargets += 1;
                    n -= m;
                    if (n == startN / 2 && y != 0)
                    {
                        n = n / y;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(countTargets);
        }
    }
}