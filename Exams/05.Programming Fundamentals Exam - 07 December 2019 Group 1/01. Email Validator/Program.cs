using System;
using System.Linq;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while (true)
            {
                string commandList = Console.ReadLine();
                if (commandList is "Complete")
                {
                    break;
                }
                string[] command = commandList.Split(" ").ToArray();

                if (commandList is "Make Upper")
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                else if (commandList is "Make Lower")
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                else if (commandList is "GetUsername")
                {
                    bool isContain = email.Contains("@");

                    if (isContain == true)
                    {
                        string[] emailparts = email.Split("@").ToArray();

                        Console.WriteLine(emailparts[0]);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (commandList is "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        Console.Write((int)email[i] + " ");
                    }
                }

                if (command[0] is "GetDomain")
                {
                    int count = int.Parse(command[1]);

                    for (int i = email.Length - count; i < email.Length; i++)
                    {
                        Console.Write(email[i]);
                    }
                    Console.WriteLine();
                }
                else if (command[0] is "Replace")
                {
                    char character = char.Parse(command[1]);

                    email = email.Replace(character, '-');
                    Console.WriteLine(email);
                }
            }
        }
    }
}
