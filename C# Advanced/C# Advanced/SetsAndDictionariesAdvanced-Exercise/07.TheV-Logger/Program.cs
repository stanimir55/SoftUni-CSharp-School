var vloggerFollowers = new Dictionary<string, SortedSet<string>>();
var vloggerFollowing = new Dictionary<string, SortedSet<string>>();
int counter = 1;

string commands;
while ((commands = Console.ReadLine()) != "Statistics")
{
    string[] arguments = commands.Split();
    string vloggerName = arguments[0];
    string name = arguments[2];

    switch (arguments[1])
    {
        case "joined":
            vloggerFollowers.TryAdd(vloggerName , new SortedSet<string>());
            vloggerFollowing.TryAdd(vloggerName , new SortedSet<string>());
            break;
        case "followed":
            if (vloggerFollowers.ContainsKey(vloggerName) &&
                vloggerFollowers.ContainsKey(name) && vloggerName != name)
            {
                vloggerFollowers[name].Add(vloggerName);
                vloggerFollowing[vloggerName].Add(name);
            }
            break;
    }
}


Console.WriteLine($"The V-Logger has a total of {vloggerFollowers.Count} vloggers in its logs.");
var sortedVlogers = vloggerFollowers
    .OrderByDescending(x => x.Value.Count)
    .ThenBy(x => vloggerFollowing[x.Key].Count);

foreach (var item in sortedVlogers)
{
    Console.WriteLine($"{counter++}. {item.Key} : {item.Value.Count} followers," +
        $" {vloggerFollowing[item.Key].Count} following");

    if (counter == 2)
    {
        foreach (var vlogger in item.Value)
        {
            Console.WriteLine($"*  {vlogger}");
        }
    }
}
