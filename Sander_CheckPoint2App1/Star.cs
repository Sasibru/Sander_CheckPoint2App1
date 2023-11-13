using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sander_CheckPoint2App1
{
	public class Star : Player
	{
		string Description { get;}
        public Star(string? name = null, string? number = null, string? description = null) : base(name, number)
        {
            Description = description ?? "Unknown Star Player";
        }

		public override string ToString()
		{
			return $"#{Number}, {Name}, star player! {Description}";
		}
	}
}
