using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_Articles_2._0
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] all = Console.ReadLine().Split(", ").ToArray();
                Article currentArticle = new Article
                {
                    Title = all[0],
                    Content = all[1],
                    Author = all[2]
                };
                articles.Add(currentArticle);
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (orderCriteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
                
            }
            else if (orderCriteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join("\n",articles));
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            string strings = $"{this.Title} - {this.Content}: {this.Author}";

            return strings;
        }
    }
}