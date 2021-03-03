using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Emoji_Detector
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@":{2}[A-Z]{1}[a-z]{2,}:{2}|\*{2}[A-Z]{1}[a-z]{2,}\*{2}");
            Regex regexDigit = new Regex(@"\d");

            string input = Console.ReadLine();
            MatchCollection match = regex.Matches(input);
            MatchCollection matchDigit = regexDigit.Matches(input);

            int countOfAllEmojis = 0;

            long coolThresholdSum = 1;

            for (int i = 0; i < matchDigit.Count; i++)
            {
                coolThresholdSum *= long.Parse(matchDigit[i].ToString());
            }
            List<string> newlist = new List<string>();

            for (int i = 0; i < match.Count; i++)
            {
                string dam = match[i].ToString();
                string before = dam;

                dam = dam.Remove(dam.Length - 2);
                dam = dam.Remove(0, 2);

                int sum = dam.Sum(b => b);

                if (sum > coolThresholdSum)
                {
                    countOfAllEmojis++;
                    newlist.Add(before);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{match.Count} emojis found in the text. The cool ones are:");
            for (int i = 0; i < newlist.Count; i++)
            {
                Console.WriteLine(newlist[i]);
            }
        }
    }
}
