using System;

namespace _03._00_Gaming_Store
{
    class Program
    {
        static void Main()
        {
            double startBalance = Double.Parse(Console.ReadLine());

            double currentBalance = startBalance;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Game Time")
                {
                    break;
                }

                if (command == "OutFall 4" || command == "CS: OG" || command == "Zplinter Zell" ||
                    command == "Honored 2" || command == "RoverWatch" || command == "RoverWatch Origins Edition")
                {
                    if (command == "OutFall 4")
                    {
                        if (currentBalance - 39.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else if (command == "CS: OG")
                    {
                        if (currentBalance - 15.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else if (command == "Zplinter Zell")
                    {
                        if (currentBalance - 19.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else if (command == "Honored 2")
                    {
                        if (currentBalance - 59.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else if (command == "RoverWatch")
                    {
                        if (currentBalance - 29.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else if (command == "RoverWatch Origins Edition")
                    {
                        if (currentBalance - 39.99 >= 0)
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${startBalance - currentBalance:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}