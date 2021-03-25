using System;
using System.Collections.Generic;

namespace _04._00_Raw_Data
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                Car currentCar = new Car()
                {
                    Model = commands[0],
                    Engine = new Engine() {Speed = int.Parse(commands[1]), Power = int.Parse(commands[2])},
                    Cargo = new Cargo() {Weight = int.Parse(commands[3]), Type = commands[4]}
                };
                cars.Add(currentCar);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.Type == "fragile" && cars[i].Cargo.Weight < 1000)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }

            if (type == "flamable")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.Type == "flamable" && cars[i].Engine.Power > 250)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }
        }
    }
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}