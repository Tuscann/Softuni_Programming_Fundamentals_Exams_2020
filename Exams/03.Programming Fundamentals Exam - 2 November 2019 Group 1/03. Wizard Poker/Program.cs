using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main()
        {
            List<string> cards = Console.ReadLine().Split(':').ToList();
            List<string> newDeck = new List<string>();

            while (true)
            {
                string commandList = Console.ReadLine();
                if (commandList is "Ready")
                {
                    break;
                }

                string[] operation = commandList.Split();

                string command = operation[0];

                if (command is "Add")
                {
                    string cardName = operation[1];
                    if (cards.Contains(cardName))
                    {
                        newDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command is "Insert")
                {
                    string cardName = operation[1];
                    int index = int.Parse(operation[2]);
                    if (cards.Contains(cardName) && index >= 0 && index <= cards.Count - 1 && index <= newDeck.Count - 1)
                    {
                        newDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command is "Remove")
                {
                    string cardName = operation[1];
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command is "Swap")
                {
                    int card1Index = newDeck.IndexOf(operation[1]);
                    int card2Index = newDeck.IndexOf(operation[2]);

                    string temp = newDeck[card1Index];
                    newDeck[card1Index] = newDeck[card2Index];
                    newDeck[card2Index] = temp;
                }
                else if (command is "Shuffle")
                {
                    newDeck.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
