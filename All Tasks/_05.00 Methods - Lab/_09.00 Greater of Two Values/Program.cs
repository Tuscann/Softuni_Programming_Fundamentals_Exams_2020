using System;

namespace _09._00_Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine(GetMax(type, first, second));
        }

        private static string GetMax(string type, string first, string second)
        {
            string returnString = "";

            if (type == "int")
            {
                if (int.Parse(first) > int.Parse(second))
                {
                    returnString = first + "";
                }
                else
                {
                    returnString = second + "";
                }
            }
            else if (type == "char")
            {
                if (char.Parse(first) > char.Parse(second))
                {
                    returnString = first + "";
                }
                else
                {
                    returnString = second + "";
                }
            }
            else if (type == "string")
            {
                if(String.Compare(first,second) < 0)
                {
                    returnString = second;
                }
                else
                {
                    returnString = first;
                }
            }

            return returnString;
        }
    }
}