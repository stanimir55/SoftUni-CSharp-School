var topResult = new Dictionary<string, int>();
var submissions = new Dictionary<string, int>();
HashSet<string> bannedUsers = new HashSet<string>();

string commands;
while ((commands = Console.ReadLine()) != "exam finished")
{
    string[] arguments = commands.Split("-");
    string username = arguments[0];

    _ = arguments[1] == "banned" ? bannedUsers.Add(username) : default;

    if (!bannedUsers.Contains(username))
    {
        string language = arguments[1];
        int points = int.Parse(arguments[2]);

        if (!submissions.ContainsKey(language))
        {
            submissions.Add(language, 0);
        }

        submissions[language]++;

        if (!topResult.ContainsKey(username))
        {
            topResult.Add(username, points);
        }

        _ = topResult[username] < points ? topResult[username] = points : default;
    }
}

Console.WriteLine("Results:");

foreach (var kvp in topResult
    .Where(x => !bannedUsers.Contains(x.Key))
    .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} | {kvp.Value}");
}

Console.WriteLine("Submissions:");

foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
}
