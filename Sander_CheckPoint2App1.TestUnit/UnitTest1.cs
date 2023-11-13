using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Sander_CheckPoint2App1.TestUnit
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void ToString_CreateNewTeam_ReturnTeamName()
		{
			Team team = new Team("OKC Thunder");
			string actual = team.ToString();

			string expected = "OKC Thunder";

			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void AddPlayer_AddNewPlayer_ReturnString()
		{
			Team team = new("Test Team");
			Player player = new("SGA", "2");
			string actual = player.ToString();

			string expected = $"#2, SGA";

			Assert.That(expected, Is.EqualTo(actual));
		}
		[Test]
		public void AddPlayer_AddNewStarPlayer_ReturnString()
		{
			Team team = new("Test Team2");
			Player player = new("Russell Westbrook", "0");
			string actual = player.ToString();

			string expected = $"#0, Russell Westbrook";

			Assert.That(expected, Is.EqualTo(actual));
		}
	}
}