using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public class Player : Team
	{
		string? Name {  get; set; }
		string? Number { get; set; }

        public Player(string? name = null, string? number = null) : base(name)
        {
            Name = name;
            Number = number;
        }

    }
}
