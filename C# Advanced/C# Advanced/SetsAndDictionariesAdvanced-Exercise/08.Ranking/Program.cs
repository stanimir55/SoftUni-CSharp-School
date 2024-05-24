var contestsPasswords = new Dictionary<string, string>();
var userContests = new SortedDictionary<string, Dictionary<string, int>>();

string commands;
while ((commands = Console.ReadLine()) != "end of contests")
{
    string[] arguments = commands.Split(":");
    string contest = arguments[0];
    string passwordForContest = arguments[1];

    contestsPasswords.Add(contest, passwordForContest);
}

while ((commands = Console.ReadLine()) != "end of submissions")
{
    string[] arguments = commands.Split("=>");
    string contest = arguments[0];
    string password = arguments[1];
    string username = arguments[2];
    int points = int.Parse(arguments[3]);

    if (!(contestsPasswords.ContainsKey(contest) && contestsPasswords[contest] == password))
    {
        continue;
    }

    if (!userContests.ContainsKey(username))
    {
        userContests.Add(username, new Dictionary<string, int>());
    }

    if (!userContests[username].ContainsKey(contest))
    {
        userContests[username].Add(contest, points);
    }

    _ = userContests[username][contest] < points ? userContests[username][contest] = points : default;
}

var bestCandidate = userContests
    .OrderByDescending(x => x.Value.Sum(x => x.Value))
    .FirstOrDefault();

Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Sum(x => x.Value)} points.");
Console.WriteLine("Ranking:");

foreach (var kvp in userContests)
{
    Console.WriteLine(kvp.Key);

    foreach (var kvpOne in kvp.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {kvpOne.Key} -> {kvpOne.Value}");
    }
}