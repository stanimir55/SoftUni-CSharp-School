int drgonsCount = int.Parse(Console.ReadLine());
var dragons = new Dictionary<string, Dictionary<string, List<double>>>();

for (int i = 0; i < drgonsCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string type = arguments[0];
    string name = arguments[1];

    double defaultDamage = 45;
    double defaultHealth = 250;
    double defaultArmor = 10;

    double newDamage;
    double newHealth;
    double newArmor;

    if (!dragons.ContainsKey(type))
    {
        dragons.Add(type, new Dictionary<string, List<double>>());
    }
    if (!dragons[type].ContainsKey(name))
    {
        dragons[type].Add(name, new List<double>());
        dragons[type][name].Add(double.TryParse(arguments[2], out newDamage) ? newDamage : defaultDamage);
        dragons[type][name].Add(double.TryParse(arguments[3], out newHealth) ? newHealth : defaultHealth);
        dragons[type][name].Add(double.TryParse(arguments[4], out newArmor) ? newArmor : defaultArmor);
    }
    else
    {
        dragons[type][name].Clear();
        dragons[type][name].Add(double.TryParse(arguments[2], out newDamage) ? newDamage : defaultDamage);
        dragons[type][name].Add(double.TryParse(arguments[3], out newHealth) ? newHealth : defaultHealth);
        dragons[type][name].Add(double.TryParse(arguments[4], out newArmor) ? newArmor : defaultArmor);
    }
}

foreach (var type in dragons)
{
    double averageDamage = 0;
    double averageHealth = 0;
    double averageArmor = 0;
    double count = 0;

    foreach (var stats in type.Value)
    {
        List<double> dragonStats = stats.Value;
        averageDamage += dragonStats[0];
        averageHealth += dragonStats[1];
        averageArmor += dragonStats[2];
        count++;
    }

    Console.WriteLine($"{type.Key}::({averageDamage / count:F2}/{averageHealth / count:F2}/{averageArmor / count:F2})");

    foreach (var dragon in type.Value.OrderBy(x => x.Key))
    {
        List<double> dragonInfo = dragon.Value;
        Console.WriteLine($"-{dragon.Key} -> damage: {dragonInfo[0]}, health: {dragonInfo[1]}, armor: {dragonInfo[2]}");
    }
}

