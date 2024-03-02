var resourceMap = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resourceMap.ContainsKey(input))
    {
        resourceMap.Add(input, 0);
    }

    resourceMap[input] += quantity;
}

foreach (var kvp in resourceMap)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}