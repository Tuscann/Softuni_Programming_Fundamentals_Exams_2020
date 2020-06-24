using System;
using System.Linq;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main()
        {

            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] commandArr = command.Split().ToArray();
                string instruction = commandArr[0];

                if (instruction == "Replace")
                {
                    char currentChar = char.Parse(commandArr[1]);
                    char newChar = char.Parse(commandArr[2]);

                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (instruction == "Cut")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (0 <= startIndex && startIndex < message.Length && 1 <= endIndex && endIndex < message.Length)
                    {
                        int length = endIndex - startIndex + 1;

                        message = message.Remove(startIndex, length);

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (instruction == "Make")
                {
                    string addition = commandArr[1];

                    if (addition == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (addition == "Lower")
                    {
                        message = message.ToLower();
                    }
                    Console.WriteLine(message);
                }
                else if (instruction == "Check")
                {
                    string substring = commandArr[1];

                    if (message.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (instruction == "Sum")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (startIndex >= 0 && endIndex < message.Length)
                    {
                        int sum = 0;
                        for (int j = startIndex; j <= endIndex; j++)
                        {
                            sum += message[j];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
