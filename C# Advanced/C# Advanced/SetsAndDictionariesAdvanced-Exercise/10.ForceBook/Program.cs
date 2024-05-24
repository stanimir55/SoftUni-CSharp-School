var forces = new Dictionary<string, HashSet<string>>();

string commands;
while ((commands = Console.ReadLine()) != "Lumpawaroo")
{
    string[] arguments = commands.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
    string forceUser = commands.Contains("|") ? arguments[1] : arguments[0];
    string forceSide = commands.Contains("->") ? arguments[1] : arguments[0];

    if (!forces.ContainsKey(forceSide))
    {
        forces.Add(forceSide, new HashSet<string>());
    }
    _ = commands.Contains("|") && !forces.Any(x => x.Value.Contains(forceUser)) ? forces[forceSide].Add(forceUser) : default;

    if (commands.Contains("->"))
    {
        if (forces.Any(x => x.Value.Contains(forceUser)))
        {
            var force = forces.First(x => x.Value.Contains(forceUser));
            force.Value.Remove(forceUser);
        }

        forces[forceSide].Add(forceUser);
        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
    }
}

foreach (var kvp in forces
    .Where(x => x.Value.Count > 0)
    .OrderByDescending(x => x.Value.Count)
    .ThenBy(x => x.Key))
{
    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
    Console.WriteLine($"! {string.Join(Environment.NewLine + "! ", kvp.Value.OrderBy(x => x).Take(kvp.Value.Count))}");
}
