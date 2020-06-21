using System;
using System.Text.RegularExpressions;

namespace _02_Boss_Rush
{
    class Program
    {
        static void Main()
        {
            int counts = int.Parse(Console.ReadLine());

            for (int i = 0; i < counts; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(@"\|{1}(?<bossName>[A-Z]{4,})\|{1}:{1}#{1}(?<title>[A-z]{1,}[ ]{1}[A-z]{1,})#{1}");

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string bossName = match.Groups["bossName"].Value;
                    string title = match.Groups["title"].Value;

                    Console.WriteLine($@"{ bossName}, The { title}");
                    Console.WriteLine($">> Strength: { bossName.Length}");
                    Console.WriteLine($">> Armour: { title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
