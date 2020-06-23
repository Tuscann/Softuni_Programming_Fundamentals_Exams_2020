using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_School_Library
{
    class Program
    {
        static void Main()
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            void Swap(int indexFirst, int indexSecound)
            {
                var tmp = books[indexFirst];
                books[indexFirst] = books[indexSecound];
                books[indexSecound] = tmp;
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands is "Done")
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (i < books.Count - 1)
                        {
                            Console.Write(books[i] + ", ");
                        }
                        else
                        {
                            Console.WriteLine(books[i]);
                        }
                    }
                    break;
                }

                string[] currentRow = commands.Split(" | ").ToArray();

                string command = currentRow[0];
                string bookname = currentRow[1];

                if (command is "Add Book")
                {
                    if (!books.Contains(bookname))
                    {
                        books.Insert(0, bookname);
                    }
                }
                else if (command is "Take Book")
                {
                    if (books.Contains(bookname))
                    {
                        books.Remove(bookname);
                    }
                }
                else if (command is "Swap Books")
                {
                    string newBookname = currentRow[2];

                    if (books.Contains(bookname) && books.Contains(newBookname))
                    {
                        int indexFirst = books.IndexOf(bookname);
                        int indexSecound = books.IndexOf(newBookname);

                        Swap(indexFirst, indexSecound);
                    }
                }
                else if (command is "Insert Book")
                {
                    books.Insert(books.Count, bookname);
                }
                else if (command is "Check Book")
                {
                    int index = int.Parse(bookname);

                    if (0 <= index && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }
            }
        }
    }
}
