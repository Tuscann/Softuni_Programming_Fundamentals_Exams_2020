using System;

namespace _05._00_Login
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            string rightPassword = Console.ReadLine();

            bool isfound = true;

            while (isfound)
            {
                string password = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    isfound = false;
                    Console.WriteLine($"User {rightPassword} blocked!");
                    break;
                }

                char[] array = password.ToCharArray();
                Array.Reverse(array);
                password = new string(array);
                if (password == rightPassword)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }

            if (isfound)
            {
                Console.WriteLine($"User {rightPassword} logged in.");
            }
        }
    }
}