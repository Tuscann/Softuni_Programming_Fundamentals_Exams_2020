using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._00_Order_by_Age
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] personData = command.Split().ToArray();

                string name = personData[0];
                string id = personData[1];
                int age = int.Parse(personData[2]);

                Person person = new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };
                people.Add(person);
            }

            people.OrderBy(p => p.Age)
                .ToList()
                .ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}