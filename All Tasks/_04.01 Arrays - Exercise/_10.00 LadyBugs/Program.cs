using System;
using System.Linq;

namespace _10._00_LadyBugs
{
    class Program
    {
        static void Main()
        {
             int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] bugsPositions = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < bugsPositions.Length; i++)
            {
                if (bugsPositions[i] < fieldSize && bugsPositions[i] >= 0)
                {
                    field[bugsPositions[i]] = 1;
                }
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ');

                int bugIndex = int.Parse(command[0]); 

                if (bugIndex >= 0 && bugIndex < fieldSize)
                {
                    string direction = command[1];
                    int step = int.Parse(command[2]);

                    if (field[bugIndex] == 1)
                    {
                        field[bugIndex] = 0;

                        if (direction == "right")
                        {
                            while (bugIndex + step < fieldSize && bugIndex + step >= 0)
                            {
                                if (field[bugIndex + step] == 0)
                                {
                                    field[bugIndex + step] = 1;
                                    break;
                                }
                                bugIndex += step;
                            }
                        }
                        else if (direction == "left")
                        {
                            while (bugIndex - step < fieldSize && bugIndex - step >= 0)
                            {
                                if (field[bugIndex - step] == 0)
                                {
                                    field[bugIndex - step] = 1;
                                    break;
                                }
                                bugIndex -= step;
                                
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}