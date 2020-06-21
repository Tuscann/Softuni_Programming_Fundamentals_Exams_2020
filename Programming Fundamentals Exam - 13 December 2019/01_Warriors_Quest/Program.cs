using System;
using System.Linq;

namespace _01_Warriors_Quest
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            while (true)
            {

                string commandsInput = Console.ReadLine();
                if (commandsInput is "For Azeroth")
                {
                    break;
                }

                string[] commands = commandsInput.Split(" ").ToArray();

                if (commands[0] is "GladiatorStance")
                {
                    password = password.ToUpper();
                    Console.WriteLine(password);
                }
                else if (commands[0] is "DefensiveStance")
                {
                    password = password.ToLower();
                    Console.WriteLine(password);
                }
                else if (commands[0] is "Dispel")
                {
                    int index = int.Parse(commands[1]);
                    string letter = commands[2];

                    if ( index < password.Length)
                    {
                        password = password.Remove(index, 1).Insert(index, letter);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (commands[0] is "Target" && commands[1] is "Change")
                {
                    string subString = commands[2];
                    string secondSubstring = commands[3];

                    password = password.Replace(subString, secondSubstring);
                    Console.WriteLine(password);
                }
                else if (commands[0] is "Target" && commands[1] is "Remove")
                {
                    string subString = commands[2];
                    int index = password.IndexOf(subString);

                    password = password.Remove(index, subString.Length);
                    Console.WriteLine(password);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
