using System;

namespace _01_Secret_Chat
{
    class Program
    {
        static void Main()
        {
            string concealedMessage = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                if (command is "Reveal")
                {
                    Console.WriteLine($"You have a new text message: {concealedMessage}");
                    break;
                }

                string[] words = command.Split(":|:");

                if (words[0] is "InsertSpace")
                {
                    int index = int.Parse(words[1]);

                    concealedMessage = concealedMessage.Insert(index, " ");

                    Console.WriteLine(concealedMessage);
                }
                else if (words[0] is "Reverse")
                {
                    string substr1 = words[1];

                    bool isfound = concealedMessage.Contains(substr1);

                    if (isfound == false)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int separatorIndex = concealedMessage.IndexOf(substr1);

                        string result = ReverseString(substr1);

                        static string ReverseString(string s)
                        {
                            char[] arr = s.ToCharArray();
                            Array.Reverse(arr);
                            return new string(arr);
                        }
                        concealedMessage = concealedMessage.Remove(separatorIndex, substr1.Length);

                        concealedMessage = concealedMessage + result;

                        Console.WriteLine(concealedMessage);
                    }
                }
                else if (words[0] is "ChangeAll")
                {
                    string substring = words[1];
                    string replacement = words[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);

                    Console.WriteLine(concealedMessage);
                }
            }
        }
    }
}
