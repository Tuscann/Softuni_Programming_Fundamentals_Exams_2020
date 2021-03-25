using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_Speed_Racing
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
                    FuelAmount = Double.Parse(commands[1]),
                    FuelConsumptionPerKilometer = Double.Parse(commands[2]),
                    TravelledDistance = 0
                };
                cars.Add(currentCar);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] commands = command.Split();

                string carModel = commands[1];
                double amountKilometers = double.Parse(commands[2]);

                cars.First(currentCar => currentCar.Model == carModel).Drive(amountKilometers);
            }

            foreach (Car currentCar in cars)
            {
                Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:F2} {currentCar.TravelledDistance}");
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        
        public void Drive(double km)
        {
            if (FuelAmount - FuelConsumptionPerKilometer * km >= 0)
            {
                FuelAmount -= FuelConsumptionPerKilometer * km;
                TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}