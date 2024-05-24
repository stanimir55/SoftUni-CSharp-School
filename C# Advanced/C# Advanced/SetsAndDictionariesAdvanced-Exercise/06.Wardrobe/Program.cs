int lineCount = int.Parse(Console.ReadLine());
var wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < lineCount; i++)
{
    string[] input = Console.ReadLine().Split(" -> ");
    string color = input[0];
    string[] clothers = input[1].Split(",");

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }

    for (int k = 0; k < clothers.Length; k++)
    {
        if (!wardrobe[color].ContainsKey(clothers[k]))
        {
            wardrobe[color].Add(clothers[k], 0);
        }

        wardrobe[color][clothers[k]] += 1;
    }
}

string[] lookUpValues = Console.ReadLine().Split();

foreach (var kvp in wardrobe)
{
    Console.WriteLine($"{kvp.Key} clothes:");

    foreach (var kvpOne in kvp.Value)
    {
        string outputValue = $"* {kvpOne.Key} - {kvpOne.Value}";

        if (kvp.Key == lookUpValues[0] && kvpOne.Key == lookUpValues[1])
        {
            outputValue += $" (found!)";
        }

        Console.WriteLine(outputValue);
    }
}