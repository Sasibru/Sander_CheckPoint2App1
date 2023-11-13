using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public abstract class Team
	{
		string? Name { get; set; }
		List<string> Players { get; set;}

        public Team(string? name = null)
        {
            Name = name;
        }
    }
}
