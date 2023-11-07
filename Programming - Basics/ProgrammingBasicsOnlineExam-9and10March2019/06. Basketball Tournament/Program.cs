string tournamentName = Console.ReadLine();

double counterWin = 0;
double counterLost = 0;
double total = 0;

while (tournamentName != "End of tournaments")
{
    int matches = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= matches; i++)
    {
        int teamDesi = int.Parse(Console.ReadLine());
        int teamOpponent = int.Parse(Console.ReadLine());
        total++;

        if (teamDesi > teamOpponent)
        {
            Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {Math.Abs(teamDesi - teamOpponent)} points.");
            counterWin++;
        }
        else
        {
            Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {Math.Abs(teamDesi - teamOpponent)} points.");
            counterLost++;
        }
    }
    tournamentName = Console.ReadLine();
}
double percentWin = counterWin * 1.0 / (total * 1.0) * 100;
double percentLost = counterLost * 1.0 / (total * 1.0) * 100;

Console.WriteLine($"{percentWin:F2}% matches win");
Console.WriteLine($"{percentLost:F2}% matches lost");
