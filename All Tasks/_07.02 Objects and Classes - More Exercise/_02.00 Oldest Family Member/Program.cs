using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._00_Oldest_Family_Member
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family myFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                string name = commands[0];
                int age = int.Parse(commands[1]);

                Person currentPerson = new Person()
                {
                    Name = name,
                    Age = age
                };
                
                myFamily.AddMember(currentPerson);
            }
            Person oldestPerson = myFamily.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }

    public class Family
    {
       public Family()
        {
            Persons = new List<Person>();
        }
       public List<Person> Persons { get; }

        public void AddMember(Person person)
        {
            Persons.Add(person);
        }

        public Person GetOldestMember()
        {
            return Persons.OrderByDescending(p => p.Age).First();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}