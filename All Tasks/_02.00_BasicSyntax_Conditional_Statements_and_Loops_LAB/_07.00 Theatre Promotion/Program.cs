using System;

namespace _07._00_Theatre_Promotion
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age >= 0 && age <= 18)
            {
                if (type == "Weekday")
                {
                    price = 12;
                }
                else if (type == "Weekend")
                {
                    price = 15;
                }
                else if (type == "Holiday")
                {
                    price = 5;
                }
            }
            else if (age >= 19 && age <= 64)
            {
                if (type == "Weekday")
                {
                    price = 18;
                }
                else if (type == "Weekend")
                {
                    price = 20;
                }
                else if (type == "Holiday")
                {
                    price = 12;
                }
            }
            else if (age >= 65 && age <= 122)
            {
                if (type == "Weekday")
                {
                    price = 12;
                }
                else if (type == "Weekend")
                {
                    price = 15;
                }
                else if (type == "Holiday")
                {
                    price = 10;
                }
            }

            if (age < 0 || age >= 123)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}