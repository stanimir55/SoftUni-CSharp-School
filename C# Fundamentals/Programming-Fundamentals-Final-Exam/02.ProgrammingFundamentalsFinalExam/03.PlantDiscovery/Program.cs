int linesCount = int.Parse(Console.ReadLine());
var plants = new Dictionary<string, int>();
var ratings = new Dictionary<string, List<double>>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split("<->");
    string plant = arguments[0];
    int rarity = int.Parse(arguments[1]);

    if (!plants.ContainsKey(plant))
    {
        plants.Add(plant, rarity);
        ratings.Add(plant, new List<double>());
    }
    else
    {
        plants[plant] = rarity;
    }
}

string commands;
while ((commands = Console.ReadLine()) != "Exhibition")
{
    string[] arguments = commands.Split(": ");

    switch (arguments[0])
    {
        case "Rate":
            string[] argument = arguments[1].Split(" - ");
            string plant = argument[0];
            int rating = int.Parse(argument[1]);

            if (!plants.ContainsKey(plant))
            {
                Console.WriteLine("error");
                continue;
            }

            ratings[plant].Add(rating);
            break;
        case "Update":
            string[] argu = arguments[1].Split(" - ");
            string updatePlant = argu[0];
            int newRarity = int.Parse(argu[1]);

            if (!plants.ContainsKey(updatePlant))
            {
                Console.WriteLine("error");
                continue;
            }

            plants[updatePlant] = newRarity;
            break;
        case "Reset":
            string currentPlant = arguments[1];

            if (!plants.ContainsKey(currentPlant))
            {
                Console.WriteLine("error");
                continue;
            }

            ratings[currentPlant].Clear();
            break;
    }
}

Console.WriteLine("Plants for the exhibition:");

foreach (var kvp in plants)
{
    foreach (var kvpOne in ratings)
    {
        var averageRating = ratings[kvp.Key].Count > 0
            ? ratings[kvp.Key].Sum() / ratings[kvp.Key].Count
            : 0.0;
        Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value}; Rating: {averageRating:F2}");
        break;
    }
}
