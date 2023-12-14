using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

List<string> validPairs = new List<string>();
List<string> mirroredPairs = new List<string>();
List<string> final = new List<string>();

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    validPairs.Add(match.ToString());
}

for (int i = 0; i < validPairs.Count; i++)
{
    string current = validPairs[i];
    string firstHalf = "";
    string secondHalfReversed = "";

    for (int k = 0; k < current.Length / 2; k++)
    {
        firstHalf += current[k];
    }

    for (int m = current.Length - 1; m >= current.Length / 2; m--)
    {
        secondHalfReversed += current[m];
    }

    if (firstHalf == secondHalfReversed)
    {
        mirroredPairs.Add(current);
    }
}

if (validPairs.Count > 0)
{
    Console.WriteLine($"{validPairs.Count} word pairs found!");
}
else
{
    Console.WriteLine("No word pairs found!");
}

if (mirroredPairs.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    string current = "";

    foreach (var pair in mirroredPairs)
    {
        string currentPair = pair.Substring(1, (pair.Length / 2) - 2);
        string currentPairOne = pair.Substring(pair.Length / 2 + 1, (pair.Length - ((pair.Length / 2) + 2)));
        current = $"{currentPair} <=> {currentPairOne}";
        final.Add(current);
    }

    Console.WriteLine(string.Join(", ", final));
}
else
{
    Console.WriteLine("No mirror words!");
}