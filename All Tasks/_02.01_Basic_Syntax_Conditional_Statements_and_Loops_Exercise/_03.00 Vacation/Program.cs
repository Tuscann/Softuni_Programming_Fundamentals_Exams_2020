using System;

namespace _03._00_Vacation
{
    class Program
    {
        static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                countOfPeople -= 10;
            }

            double price = 0.0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }

                if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }

                if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }

                if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }

                if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }

                if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }

                if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
            }

            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                price *= 0.85;
            }

            if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                price *= 0.95;
            }

            Console.WriteLine($"Total price: {price * countOfPeople:f2}");
        }
    }
}