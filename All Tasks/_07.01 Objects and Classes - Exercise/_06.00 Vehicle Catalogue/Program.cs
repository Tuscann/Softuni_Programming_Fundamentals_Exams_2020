using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._00_Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            VehicleCatalogue catalogue = new VehicleCatalogue();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] comands = command.Split().ToArray();

                string typeOfVehicle = comands[0];
                string model = comands[1];
                string color = comands[2];
                double horsepower = Double.Parse(comands[3]);

                if (typeOfVehicle == "car")
                {
                    Car currentcar = new Car
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsepower,
                        Type = typeOfVehicle
                    };
                    catalogue.Cars.Add(currentcar);
                }
                else if (typeOfVehicle == "truck")
                {
                    Truck currentTruck = new Truck
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsepower,
                        Type = typeOfVehicle
                    };
                    catalogue.Trucks.Add(currentTruck);
                }
            }

            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }

                for (int i = 0; i < catalogue.Trucks.Count; i++)
                {
                    if (catalogue.Trucks[i].Model == model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {catalogue.Trucks[i].Model}");
                        Console.WriteLine($"Color: {catalogue.Trucks[i].Color}");
                        Console.WriteLine($"Horsepower: {catalogue.Trucks[i].HorsePower}");
                    }
                }

                for (int i = 0; i < catalogue.Cars.Count; i++)
                {
                    if (catalogue.Cars[i].Model == model)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {catalogue.Cars[i].Model}");
                        Console.WriteLine($"Color: {catalogue.Cars[i].Color}");
                        Console.WriteLine($"Horsepower: {catalogue.Cars[i].HorsePower}");
                    }
                }
            }
            if (catalogue.Cars.Count == 0)
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine(
                    $"Cars have average horsepower of: {catalogue.Cars.Sum(a => a.HorsePower) / catalogue.Cars.Count:f2}.");    
            }
            
            if (catalogue.Trucks.Count == 0)
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine(
                    $"Trucks have average horsepower of: {catalogue.Trucks.Sum(a => a.HorsePower) / catalogue.Trucks.Count:f2}.");     
            }
        }
    }

    class VehicleCatalogue
    {
        public List<Car> Cars = new List<Car>();
        public List<Truck> Trucks = new List<Truck>();
    }

    class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }

    class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
}