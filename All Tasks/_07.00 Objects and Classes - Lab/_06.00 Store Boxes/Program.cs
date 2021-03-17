using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._00_Store_Boxes
{
    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commands = command.Split().ToArray();

                string serialNumber = commands[0];
                string itemName = commands[1];
                int itemQuantity = int.Parse(commands[2]);
                decimal itemPrice = decimal.Parse(commands[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Quantity = itemQuantity,
                    Price = itemQuantity * itemPrice
                };

                box.Item = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };

                boxes.Add(box);
            }

            List<Box> orderBoxes = boxes.OrderByDescending(b => b.Price).ToList();

            foreach (Box box in orderBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}