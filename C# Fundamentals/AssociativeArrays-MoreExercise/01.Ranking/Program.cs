var contests = new Dictionary<string, string>();
var namesAndPoints = new Dictionary<string, Dictionary<string, int>>();

string commands;
while ((commands = Console.ReadLine()) != "end of contests")
{
    string[] arguments = commands.Split(":");
    string contestName = arguments[0];
    string password = arguments[1];

    contests[contestName] = password;
}

while ((commands = Console.ReadLine()) != "end of submissions")
{
    string[] arguments = commands.Split("=>");
    string contest = arguments[0];
    string password = arguments[1];
    string userName = arguments[2];
    int points = int.Parse(arguments[3]);

    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!namesAndPoints.ContainsKey(userName))
        {
            namesAndPoints[userName] = new Dictionary<string, int>();
        }
        if (namesAndPoints.ContainsKey(userName) && !namesAndPoints[userName].ContainsKey(contest))
        {
            namesAndPoints[userName][contest] = 0;
        }
        if (namesAndPoints[userName][contest] < points)
        {
            namesAndPoints[userName][contest] = points;
        }
    }
}

string winner = namesAndPoints.OrderBy(x => x.Value.Values.Sum()).Last().Key;
decimal bestPoints = namesAndPoints.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");
Console.WriteLine("Ranking:");

foreach (var kvp in namesAndPoints.OrderBy(x => x.Key))
{
    Console.WriteLine(kvp.Key);

    foreach (var contest in kvp.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}