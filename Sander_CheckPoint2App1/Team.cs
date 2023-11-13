using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public class Team
	{
		string? Name { get;}
		private List<Player> Players { get; set;} = new();

        public Team(string? name = null)
        {
            Name = name ?? "Unkown Team Name";
        }

		public void AddPlayer(Player player)
		{
			Players.Add(player);
		}

		public List<Player> GetPlayersList() 
		{ 
			return new(Players); 
		}

		public override string ToString()
		{
			return $"{Name}";
		}

		public void PrintTeam()
		{
            Console.WriteLine(Name);

            Console.WriteLine("------------");
            foreach (Player player in Players)
			{
				Console.WriteLine(player);
			}
        }
	}
}
