using System;

namespace _11._00_Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());
            double sum = length * width * heigth/3;
            Console.WriteLine($"Pyramid Volume: {sum:f2}");
        }
    }
}