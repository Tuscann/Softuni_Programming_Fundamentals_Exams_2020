using System;

namespace _01._00_Data_Type_Finder
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string dataType = "";

                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (Int32.TryParse(input, out _))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out _))
                {
                    dataType = "floating point";
                }
                else if (bool.TryParse(input, out _))
                {
                    dataType = "boolean";
                }
                else if (char.TryParse(input, out _))
                {
                    dataType = "character";
                }
                else
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");
            }
        }
    }
}