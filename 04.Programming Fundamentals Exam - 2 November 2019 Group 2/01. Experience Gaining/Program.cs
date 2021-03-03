using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main()
        {
            double neededExpirience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            int realCountBattles = 0;
            double realExpirience = 0;

            for (int batle = 1; batle <= countOfBattles; batle++)
            {
                double experince = double.Parse(Console.ReadLine());
                realExpirience += experince;
                realCountBattles++;
                               
                if (batle % 3 == 0)
                {
                    experince *= 0.15;
                    realExpirience += experince;
                }
                if (batle % 5 == 0)
                {
                    experince *= 0.10;
                    realExpirience -= experince;
                }
                if (realExpirience >= neededExpirience)
                {
                    break;
                }
            }            

            if (realExpirience < neededExpirience)
            {
                Console.WriteLine("Player was not able to collect the needed experience, {0:0.00} more needed.", neededExpirience - realExpirience);
            }
            else
            {
                Console.WriteLine($"Player successfully collected his needed experience for {realCountBattles} battles.");
            }
        }
    }
}
