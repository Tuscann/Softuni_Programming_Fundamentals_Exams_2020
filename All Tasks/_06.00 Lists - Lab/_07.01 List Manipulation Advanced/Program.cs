using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._01_List_Manipulation_Advanced
{
    class Program
    {
        static void Main()
        {
             List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();

            string command = string.Empty;
            int count = 0;

            while (command != "end")
            {
                command = Console.ReadLine().ToLower();
                string[] parts = command.Split();

                if (parts[0] == "add")
                {
                    int numberToAdd = int.Parse(parts[1]);
                    numbers.Add(numberToAdd);
                }
                else if (parts[0] == "remove")
                {
                    int numberToRemove = int.Parse(parts[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (parts[0] == "removeat")
                {
                    int numberToRemoveAt = int.Parse(parts[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else if (parts[0] == "insert")
                {
                    int numberToInsert = int.Parse(parts[1]);
                    int indexToInsert = int.Parse(parts[2]);

                    numbers.Insert(indexToInsert, numberToInsert);
                }

                if (parts[0] == "add" || parts[0] == "remove" || parts[0] == "removeat"
                    || parts[0] == "insert")
                {
                    count++;
                }

                if (parts[0] == "contains")
                {
                    if (numbers.Contains(int.Parse(parts[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (parts[0] == "printeven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNums.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", evenNums));
                }
                else if (parts[0] == "printodd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            oddNums.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", oddNums));
                }
                else if (parts[0] == "getsum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if(parts[0] == "filter")
                {
                    string condition = parts[1];
                    int  numberFilter = int.Parse(parts[2]);
                    
                    List<int> filterSmall = new List<int>();

                    if (condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < numberFilter)
                            {
                                filterSmall.Add(numbers[i]);
                            }
                        }
                    }
                    else if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > numberFilter)
                            {
                                filterSmall.Add(numbers[i]);
                            }
                        }
                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= numberFilter)
                            {
                                filterSmall.Add(numbers[i]);
                            }
                        }
                    }
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= numberFilter)
                            {
                                filterSmall.Add(numbers[i]);
                            }
                        }
                    } 
                    Console.WriteLine(string.Join(" ", filterSmall));
                }
            }

            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}