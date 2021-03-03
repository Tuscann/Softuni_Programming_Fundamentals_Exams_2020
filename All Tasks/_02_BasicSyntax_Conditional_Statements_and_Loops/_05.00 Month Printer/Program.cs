using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main()
        {
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                DateTime date = new DateTime(2020, month, 1);

                Console.WriteLine(date.ToString("MMMM"));
            }
        }
    }
}