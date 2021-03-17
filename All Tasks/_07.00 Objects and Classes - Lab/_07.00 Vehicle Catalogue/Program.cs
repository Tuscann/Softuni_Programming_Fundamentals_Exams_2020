using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._00_Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            Catalog vehicleCatalog = new Catalog();

            while (true)
            {
                string inpit = Console.ReadLine();

                if (inpit == "end")
                {
                    break;
                }

                string[] command = inpit.Split('/');

                string type = command[0];
                string brand = command[1];
                string model = command[2];

                switch (type)
                {
                    case "Car":
                        int horsePower = int.Parse(command[3]);
                        Car car = new Car
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = horsePower
                        };

                        vehicleCatalog.Cars.Add(car);
                        break;

                    case "Truck":
                        int weight = int.Parse(command[3]);
                        Truck truck = new Truck
                        {
                            Brand = brand,
                            Model = model,
                            Weight = weight
                        };

                        vehicleCatalog.Trucks.Add(truck);
                        break;
                }
            }

            if (vehicleCatalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderCatalogCars = vehicleCatalog.Cars.OrderBy(c => c.Brand).ToList();

                foreach (Car car in orderCatalogCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicleCatalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                List<Truck> orderCatalogTrucks = vehicleCatalog.Trucks.OrderBy(c => c.Brand).ToList();
                
                foreach (Truck truck in orderCatalogTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
}