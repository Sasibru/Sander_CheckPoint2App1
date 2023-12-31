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
		public void AddPlayer_AddNewStarPlayer_ReturnStringWithDefaultDescription()
		{
			Team team = new("Test Team2");
			Star starPlayer = new("Russell Westbrook", "0");
			string actual = starPlayer.ToString();

			string expected = $"#0, Russell Westbrook, star player! Unknown Star Player";

			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void GetPlayers_CreateNewTeam_ReturnTeamListCount()
		{
			Team team = new("A Great Team");
			Player aGreatCenter = new("Shaquille O�Neal", "34");
			Player theNotGoat = new("Kevin Durant", "35");
			Star theGoat = new("Michael Jordan", "23", "The undisputed GOAT");

			team.AddPlayer(aGreatCenter);
			team.AddPlayer(theNotGoat);
			team.AddPlayer(theGoat);

			int actual = team.GetPlayersList().Count;

			int expected = 3;

			Assert.That(expected, Is.EqualTo(actual));
		}
	}
}