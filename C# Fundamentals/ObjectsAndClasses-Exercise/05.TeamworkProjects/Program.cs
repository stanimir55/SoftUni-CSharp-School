int teamCounts = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();

for (int i = 0; i < teamCounts; i++)
{
    string[] arguments = Console.ReadLine().Split("-");

    Team team = new Team(arguments[1], arguments[0]);

    Team sameTeamFound = teams.Find(t => t.Name == team.Name);
    Team sameCreatorFound = teams.Find(t => t.Creator == team.Creator);

    if (sameTeamFound != null)
    {
        Console.WriteLine($"Team {sameTeamFound.Name} was already created!");
        continue;
    }

    if (sameCreatorFound != null)
    {
        Console.WriteLine($"{sameCreatorFound.Creator} cannot create another team!");
        continue;
    }

    teams.Add(team);
    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
}

string command;

while ((command = Console.ReadLine()) != "end of assignment")
{
    string[] arguments = command.Split("->");
    string joinerName = arguments[0];
    string teamName = arguments[1];

    bool hasAnyTeamWithSameName = teams.Any(t => t.Name == teamName);

    if (hasAnyTeamWithSameName == false)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (teams.Any(team => team.Creator == joinerName) ||
        teams.Any(team => team.Members.Contains(joinerName)))
    {
        Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
        continue;
    }

    teams.First(t => t.Name == teamName).Members.Add(joinerName);
}

List<Team> validTeam = new List<Team>();
List<Team> disbandTeam = new List<Team>();

for (int i = 0; i < teams.Count; i++)
{
    if (teams[i].Members.Count == 0)
    {
        disbandTeam.Add(teams[i]);
    }
    else
    {
        validTeam.Add(teams[i]);
    }
}

foreach (Team item in validTeam.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
{
    Console.WriteLine(item.Name);
    Console.WriteLine($"- {item.Creator}");
    foreach (string member in item.Members.OrderBy(member => member))
    {
        Console.WriteLine($"-- {member}");
    }
}

Console.WriteLine("Teams to disband:");

if (disbandTeam != null)
{
    foreach (Team item in disbandTeam.OrderBy(x => x.Name))
    {
        Console.WriteLine(item.Name);
    }
}


class Team
{
    public Team(string teamName, string creatorName)
    {
        Name = teamName;
        Creator = creatorName;
        Members = new List<string>();
    }

    public string Name { get; set; }

    public string Creator { get; set; }

    public List<string> Members { get; set; }

    public override string ToString()
    {
        return $"{Name}\n" +
            $"- {Creator}\n" +
            $"{GetMembersString()}";
    }

    private string GetMembersString()
    {
        Members = Members
            .OrderBy(name => name)
            .ToList();

        string result = string.Empty;

        for (int i = 0; i < Members.Count - 1; i++)
        {
            result += $"-- {Members[i]}\n";
        }

        result += $"-- {Members[Members.Count - 1]}";

        return result;
    }
}