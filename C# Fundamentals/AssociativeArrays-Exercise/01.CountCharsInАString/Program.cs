var charOccurrences = new Dictionary<char, int>();
string words = Console.ReadLine();

for (int i = 0; i < words.Length; i++)
{
    if (words[i] == ' ')
    {
        continue;
    }

    if (!charOccurrences.ContainsKey(words[i]))
    {
        charOccurrences.Add(words[i], 0);
    }

    charOccurrences[words[i]]++;
}

foreach (var kvp in charOccurrences)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}