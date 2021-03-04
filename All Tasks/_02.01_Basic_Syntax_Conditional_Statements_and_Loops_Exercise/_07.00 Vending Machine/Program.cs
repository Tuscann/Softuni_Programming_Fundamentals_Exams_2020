using System;

namespace _07._00_Vending_Machine
{
    class Program
    {
        static void Main()
        {
            double totalMoney = 0.0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }

                if (command == "0.1" || command == "0.2" || command == "0.5" || command == "1" || command == "2")
                {
                    totalMoney += Double.Parse(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                if (command == "nuts" || command == "water" || command == "crisps" || command == "soda" ||
                    command == "coke")
                {
                    if (command == "nuts" && totalMoney - 2 >= 0)
                    {
                        totalMoney -= 2;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else if (command == "water" && totalMoney - 0.7 >= 0)
                    {
                        totalMoney -= 0.7;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else if (command == "crisps" && totalMoney - 1.5 >= 0)
                    {
                        totalMoney -= 1.5;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else if (command == "soda" && totalMoney - 0.8 >= 0)
                    {
                        totalMoney -= 0.8;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else if (command == "coke" && totalMoney - 1 >= 0)
                    {
                        totalMoney -= 1;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                }
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}