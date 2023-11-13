using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public class Star : Player
	{
		string Description { get; set; }
        public Star(string? name = null, string? number = null, string? description = null) : base(name, number)
        {
            Description = description ?? "Unkown Star Player";
        }

    }
}
