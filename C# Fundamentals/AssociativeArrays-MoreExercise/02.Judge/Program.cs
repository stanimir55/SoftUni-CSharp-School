string command;
var contests = new Dictionary<string, Dictionary<string, int>>();
var users = new Dictionary<string, int>();

while ((command = Console.ReadLine()) != "no more time")
{
    string[] arguments = command
        .Split("->")
        .ToArray();

    string userName = arguments[0];
    string contest = arguments[1];
    int points = int.Parse(arguments[2]);

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, new Dictionary<string, int>());
        contests[contest][userName] = points;
    }
    else
    {
        if (!contests[contest].ContainsKey(userName))
        {
            contests[contest][userName] = points;
        }
        else
        {
            if (contests[contest][userName] < points)
            {
                contests[contest][userName] = points;
            }
        }
    }
}

foreach (var kvp in contests)
{
    Console.WriteLine($"{kvp.Key.Trim()}: {kvp.Value.Count()} participants");

    int counter = 1;

    foreach (var contest in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        Console.WriteLine($"{counter}. {contest.Key.Trim()} <::> {contest.Value}");
        counter++;
    }
}

Console.WriteLine("Individual standings:");
foreach (var contest in contests)
{
    foreach (var name in contest.Value)
    {
        if (!users.ContainsKey(name.Key))
        {
            users.Add(name.Key, name.Value);
        }
        else
        {
            users[name.Key] = users[name.Key] + name.Value;
        }
    }
}

int count = 1;

foreach (var kvp in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
        Console.WriteLine($"{count}. {kvp.Key}-> {kvp.Value}");
        count++;
}