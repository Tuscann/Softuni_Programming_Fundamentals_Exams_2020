using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._00_Songs
{
    class Program
    {
        static void Main()
        {
            List<Song> newSongs = new List<Song>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> current = Console.ReadLine().Split("_").ToList();

                Song currentSong = new Song();

                currentSong.TypeList = current[0];
                currentSong.Name = current[1];
                currentSong.Time = current[2];

                newSongs.Add(currentSong);
            }

            string type = Console.ReadLine();

            if (type == "all")
            {
                for (int i = 0; i < newSongs.Count; i++)
                {
                    Console.WriteLine(newSongs[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < newSongs.Count; i++)
                {
                    if (newSongs[i].TypeList == type)
                    {
                        Console.WriteLine(newSongs[i].Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}