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
	}
}