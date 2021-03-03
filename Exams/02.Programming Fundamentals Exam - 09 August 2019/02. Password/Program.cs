using System;
using System.Text.RegularExpressions;

namespace _02._Password
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                string pattern = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";
                Regex rgx = new Regex(pattern);

                bool isFound = Regex.IsMatch(current, pattern);

                if (isFound)
                {
                    foreach (Match match in rgx.Matches(current))
                    {
                        Console.WriteLine($"Password: {match.Groups[2]}{match.Groups[3]}{match.Groups[4]}{match.Groups[5]}");
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
