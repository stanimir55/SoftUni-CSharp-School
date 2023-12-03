List<string> words = Console.ReadLine()
    .Split()
    .ToList();

var charOccurrences = new Dictionary<char,int>();

for (int i = 0; i < words.Count; i++)
{
    string result = words[i];

    for (int k = 0; k < result.Length; k++)
    {
        char character = result[k];

        if (!charOccurrences .ContainsKey(character))
        {
            charOccurrences [character] = 1;
            continue;
        }

        charOccurrences [character]++;
    }
}

foreach (KeyValuePair<char,int> kvp in charOccurrences )
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}