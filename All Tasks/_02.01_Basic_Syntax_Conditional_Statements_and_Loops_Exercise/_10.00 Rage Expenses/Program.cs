using System;

namespace _10._00_Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = Double.Parse(Console.ReadLine());
            double mousePrice = Double.Parse(Console.ReadLine());
            double keyboardPrice = Double.Parse(Console.ReadLine());
            double displayPrice = Double.Parse(Console.ReadLine());

            int countHeadSet = 0;
            int countMouse = 0;
            int countKeyboard = 0;
            int countDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    countHeadSet += 1;
                }

                if (i % 3 == 0)
                {
                    countMouse += 1;
                }

                if (i % 6 == 0)
                {
                    countKeyboard += 1;
                }

                if (i % 12 == 0)
                {
                    countDisplay += 1;
                }
            }

            double totalPrice = countHeadSet * headSetPrice + countDisplay * displayPrice +
                                countKeyboard * keyboardPrice + countMouse * mousePrice;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}