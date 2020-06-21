using System;
using System.Text;

namespace _01_Password_Reset
{
    class Program
    {
        static void Main()
        {
            string rawPassword = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] splitted = command.Split(' ');
                string action = splitted[0];

                if (action == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < rawPassword.Length; i += 2)
                    {
                        sb.Append(rawPassword[i]);
                    }
                    rawPassword = sb.ToString();
                    Console.WriteLine(rawPassword);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]);
                    int test = startIndex + length;

                    if (test <= rawPassword.Length)
                    {
                        string substr = rawPassword.Substring(startIndex, length);
                        int index = rawPassword.IndexOf(substr);
                        rawPassword = rawPassword.Remove(index, substr.Length);
                        Console.WriteLine(rawPassword);
                    }

                }
                else if (action == "Substitute")
                {
                    string oldChar = splitted[1];
                    string newChar = splitted[2];

                    if (rawPassword.Contains(oldChar))
                    {
                        rawPassword = rawPassword.Replace(oldChar, newChar);
                        Console.WriteLine(rawPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {rawPassword}");
        }
    }
}
