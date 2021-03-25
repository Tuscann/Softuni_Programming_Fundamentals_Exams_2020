using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Shopping_Spree
{
    class Program
    {
        static void Main()
        {
            string first = Console.ReadLine();

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            if (!first.Contains(";"))
            {
                string[] commands = first.Split("=");

                Person onlyPerson = new Person()
                {
                    Name = commands[0],
                    Money = int.Parse(commands[1])
                };
                string[] productss = Console.ReadLine().Split("=");
                products.Add(new Product() {Name = productss[0], Cost = int.Parse(productss[1])});

                people.Add(onlyPerson);

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] commandss = input.Split(" ");

                    Person currentPerson = people.First(p => p.Name == commandss[0]);
                    Product currentProduct = products.First(p => p.Name == commandss[1]);

                    currentPerson.buyProduct(products, currentProduct);
                }
            }
            else
            {
                string[] peopless = first.Split(";");

                for (int i = 0; i < peopless.Length; i++)
                {
                    string[] commands = peopless[i].Split("=");
                    
                    Person person = new Person()
                    {
                        Name = commands[0],
                        Money = int.Parse(commands[1])
                    };
                    people.Add(person);
                }
                string[] productss = Console.ReadLine().Split(";");

                for (int i = 0; i < productss.Length-1; i++)
                {
                    string[] commands = productss[i].Split("=");

                    products.Add(new Product() {Name = commands[0], Cost = int.Parse(commands[1])});
                }

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] commandss = input.Split(" ");

                    Person currentPerson = people.First(p => p.Name == commandss[0]);
                    Product currentProduct = products.First(p => p.Name == commandss[1]);

                    currentPerson.buyProduct(products, currentProduct);
                }
                
            }

            foreach (Person person in people)
            {
                if (person.Products.Count > 0)
                {
                    List<string> productNames = new List<string>();
                    foreach (Product product in person.Products)
                    {
                        productNames.Add(product.Name);
                    }

                    Console.WriteLine($"{person.Name} - {String.Join(", ", productNames)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }

    public class Person
    {
        public Person()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> Products { get; set; }

        public void buyProduct(List<Product> products, Product product)
        {
            Product hmm = products.Find(searchedProduct => searchedProduct.Name == product.Name);
            if (hmm.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                Money -= hmm.Cost;
                Products.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}