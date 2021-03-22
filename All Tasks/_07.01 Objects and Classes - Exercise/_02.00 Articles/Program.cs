using System;
using System.Linq;

namespace _02._00_Articles
{
    class Program
    {
        static void Main()
        {
            string[] all = Console.ReadLine().Split(", ").ToArray();

            int n = int.Parse(Console.ReadLine());

            Article currentArticle = new Article
            {
                Title = all[0],
                Content = all[1],
                Author = all[2],
            };

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();

                if (commands[0] == "Edit")
                {
                    currentArticle.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    currentArticle.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    currentArticle.Rename(commands[1]);
                }
            }

            Console.WriteLine(currentArticle);
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            string strings = $"{this.Title} - {this.Content}: {this.Author}";

            return strings;
        }
    }
}