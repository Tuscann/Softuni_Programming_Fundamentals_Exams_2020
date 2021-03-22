using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._00_Teamwork_Projects
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>(n);

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split("-").ToArray();

                string playerName = commands[0];
                string teamName = commands[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator.Name == playerName))
                {
                    Console.WriteLine($"{playerName} cannot create another team!");
                }
                else
                {
                    Player player = new Player
                    {
                        Name = playerName
                    };

                    Team team = new Team
                    {
                        Name = teamName,
                        Creator = player
                    };

                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {player.Name}!");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of assignment")
                {
                    break;
                }

                string[] joinCommand = command.Split("->").ToArray();

                string playerName = joinCommand[0];
                string teamName = joinCommand[1];

                if (teams.All(team => team.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Creator.Name == playerName || t.Players.Any(p => p.Name == playerName)))
                {
                    Console.WriteLine($"Member {playerName} cannot join team {teamName}!");
                }
                else
                {
                    Player player = new Player
                    {
                        Name = playerName
                    };

                    teams.First(t => t.Name == teamName).Players.Add(player);
                }
            }

            foreach (Team team in teams.Where(t => t.Players.Count != 0).OrderByDescending(t => t.Players.Count)
                .ThenBy(t => t.Name))
            {
                Console.WriteLine($"{team.Name}\n- {team.Creator.Name}");

                List<Player> orderByName = team.Players.OrderBy(p => p.Name).ToList();

                orderByName.ForEach(player => Console.WriteLine($"-- {player.Name}"));
            }

            Console.WriteLine("Teams to disband:");

            teams.Where(t => t.Players.Count == 0).OrderBy(t => t.Name).ToList()
                .ForEach(t => Console.WriteLine(t.Name));
        }

        public class Team
        {
            public Team()
            {
                this.Players = new List<Player>();
            }

            public string Name { get; set; }
            public Player Creator { get; set; }
            public List<Player> Players { get; }
        }

        public class Player
        {
            public string Name { get; set; }
        }
    }
}