int linesCount = int.Parse(Console.ReadLine());
var continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string continent = arguments[0];
    string country = arguments[1];
    string city = arguments[2];

    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();
    }

    continents[continent][country].Add(city);
}

foreach (var kvp in continents)
{
    Console.WriteLine($"{kvp.Key}:");

    foreach (var kvpOne in kvp.Value)
    {
        Console.WriteLine($"  {kvpOne.Key} -> {string.Join(", ", kvpOne.Value)}");
    }
}