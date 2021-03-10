using System;

namespace _06._00_Calculate_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = CalculateArea(width, height);

            Console.WriteLine(rectangleArea);
        }

        private static double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}