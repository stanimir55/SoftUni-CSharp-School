var shops = new SortedDictionary<string, Dictionary<string, double>>();

string commands;
while ((commands = Console.ReadLine()) != "Revision")
{
    string[] arguments = commands.Split(", ");
    string shop = arguments[0];
    string product = arguments[1];
    double price = double.Parse(arguments[2]);

    if (!shops.ContainsKey(shop))
    {
        shops[shop] = new Dictionary<string, double>();
    }

    shops[shop].Add(product, price);
}

foreach (var kvp in shops)
{
    Console.WriteLine($"{kvp.Key}->");

    foreach (var kvpOne in kvp.Value)
    {
        Console.WriteLine($"Product: {kvpOne.Key}, Price: {kvpOne.Value}");
    }
}