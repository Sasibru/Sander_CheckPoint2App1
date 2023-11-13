using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public class Player
	{
		public string? Name {  get;}
		public string? Number { get; private set; }

        public Player(string? name = null, string? number = null)
        {
            Name = name ?? "Unkown Player Name";
            Number = number ?? "Unkown Number";
        }


		public override string ToString()
		{
			return $"#{Number}, {Name}";
		}
	}
}
