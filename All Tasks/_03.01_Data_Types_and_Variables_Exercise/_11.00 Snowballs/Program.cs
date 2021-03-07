using System;
using System.Numerics;

namespace _11._00_Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxSnowBallPower = -1;

            double bestsnowballSnow = 0;
            double bestsnowballTime = 0;
            double bestsnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowBallPower = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (currentSnowBallPower >= maxSnowBallPower)
                {
                    bestsnowballTime = snowballTime;
                    bestsnowballSnow = snowballSnow;
                    bestsnowballQuality = snowballQuality;
                    maxSnowBallPower = currentSnowBallPower;
                }
            }

            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {maxSnowBallPower} ({bestsnowballQuality})");
        }
    }
}