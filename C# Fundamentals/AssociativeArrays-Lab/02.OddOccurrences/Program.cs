string[] words = Console.ReadLine()
    .Split()
    .Select(x => x.ToLower())
    .ToArray();

var wordCurrences = new Dictionary<string, int>();

for (int i = 0; i < words.Length; i++)
{
    string currentWord = words[i];

    if (!wordCurrences.ContainsKey(currentWord))
    {
        wordCurrences.Add(currentWord, 0);
    }

    wordCurrences[currentWord]++;
}

foreach (KeyValuePair<string, int> kvp in wordCurrences)
{
    if (kvp.Value % 2 == 1)
    {
        Console.Write($"{kvp.Key} ");
    }
}
