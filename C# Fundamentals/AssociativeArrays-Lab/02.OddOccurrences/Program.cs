List<string> words = Console.ReadLine()
    .Split()
    .Select(x => x.ToLower())
    .ToList();
var wordCurrences = new Dictionary<string, int>();

for (int i = 0; i < words.Count; i++)
{
    if (!wordCurrences.ContainsKey(words[i]))
    {
        wordCurrences.Add(words[i], 0);
    }

    wordCurrences[words[i]]++;
}

foreach (KeyValuePair<string, int> kvp in wordCurrences)
{
    if (kvp.Value % 2 == 1)
    {
        Console.Write($"{kvp.Key} ");
    }
}
