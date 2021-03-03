using System;
using System.Linq;

namespace _01_Activation_Keys
{
    class Program
    {
        static void Main()
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command is "Generate")
                {
                    Console.WriteLine($"Your activation key is: {activationKey}");
                    break;
                }

                string[] all = command.Split(">>>").ToArray();

                string currentCommand = all[0];

                if (currentCommand is "Contains")
                {
                    string substring = all[1];

                    bool isfound = activationKey.Contains(substring);

                    if (isfound)
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (currentCommand is "Flip")
                {
                    string position = all[1];
                    int startIndex = int.Parse(all[2]);
                    int endIndex = int.Parse(all[3]);

                    string x = activationKey.Substring(startIndex, endIndex-startIndex);

                    if (position is "Upper")
                    {
                        x = x.ToUpper();
                    }
                    else if (position is "Lower")
                    {
                        x = x.ToLower();
                    }

                    string dam = activationKey.Remove(startIndex, endIndex - startIndex);

                    activationKey = dam;
                    activationKey = activationKey.Insert(startIndex, x);
                    Console.WriteLine(activationKey);
                }
                else if (currentCommand is "Slice")
                {
                    int startIndex = int.Parse(all[1]);
                    int endIndex = int.Parse(all[2]);

                    string x = activationKey.Remove(startIndex, endIndex - startIndex);

                    activationKey = x;
                    Console.WriteLine(activationKey);
                }
            }
        }
    }
}