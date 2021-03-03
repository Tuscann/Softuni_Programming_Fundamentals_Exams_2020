using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());

            int succesCount = 0;

            for (int i = 0; i < counts; i++)
            {
                string word = Console.ReadLine();

                Regex regex = new Regex(@"(U\$){1}(?<user>[A-Z]{1}[a-z]{2,})(U\$){1}P@\${1}(?<password>[A-z]{5,}[\d]{1,})P@\${1}");

                Match match = regex.Match(word);

                if (match.Success)
                {
                    Console.WriteLine("Registration was successful\nUsername: {0}, Password: {1}",
                                      match.Groups["user"].Value,
                                      match.Groups["password"].Value);
                    succesCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: { succesCount}");
        }
    }
}