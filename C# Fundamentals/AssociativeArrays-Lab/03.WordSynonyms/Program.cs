int number = int.Parse(Console.ReadLine());
var dictionary = new Dictionary<string, string>();

for (int i = 0; i < number; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!dictionary.ContainsKey(word))
    {
        dictionary[word] = synonym;
    }
    else
    {
        dictionary[word] += ", " + synonym;
    }
}

foreach (KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
}