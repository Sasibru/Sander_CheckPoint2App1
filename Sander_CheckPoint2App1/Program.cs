namespace Sander_CheckPoint2App1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Team team = new("A Great Team");
			Player aGreatCenter = new("Shaquille O’Neal", "34");
			Player theNotGoat = new("Kevin Durant", "35");
			Star theGoat = new("Michael Jordan", "23", "The undisputed GOAT");

			team.AddPlayer(aGreatCenter);
			team.AddPlayer(theNotGoat);
			team.AddPlayer(theGoat);

			team.PrintTeam();

		}
	}
}