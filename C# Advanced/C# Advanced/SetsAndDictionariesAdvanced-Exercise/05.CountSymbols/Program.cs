string input = Console.ReadLine();
SortedDictionary<char, int> charOccurences = new SortedDictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    if (!charOccurences.ContainsKey(input[i]))
    {
        charOccurences.Add(input[i], 0);
    }

    charOccurences[input[i]]++;
}

foreach (var kvp in charOccurences)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
}