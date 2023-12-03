string resource = Console.ReadLine();

var result = new Dictionary<string, int>();

while (resource  != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!result.ContainsKey(resource))
    {

        result[resource] = quantity;
    }
    else
    {
        result[resource] += quantity;
    }

    resource = Console.ReadLine();
}

foreach (KeyValuePair<string,int> kvp in result)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}