using System;

namespace _01_Disneyland_Journey
{
    class Program
    {
        static void Main()
        {
            double priceJourney = double.Parse(Console.ReadLine());
            int numbersCount = int.Parse(Console.ReadLine());

            double sumTotal = 0;

            double permouth = priceJourney / 4;
            
            for (int i = 1; i <= numbersCount; i++)
            {
                if (i > 1 && i % 2 != 0)
                {
                    sumTotal *= 0.84;
                }

                if (i % 4 == 0)
                {
                    sumTotal *= 1.25;
                }
                sumTotal += permouth;
            }

            if (sumTotal >= priceJourney)
            {
                Console.WriteLine("Bravo! You can go to Disneyland and you will have {0:0.00}lv. for souvenirs.", sumTotal - priceJourney);
            }
            else
            {
                Console.WriteLine("Sorry. You need {0:0.00}lv. more.", priceJourney - sumTotal);
            }
        }
    }
}
