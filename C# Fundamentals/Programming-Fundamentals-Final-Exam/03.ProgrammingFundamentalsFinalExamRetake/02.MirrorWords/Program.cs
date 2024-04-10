using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

List<string> validPairs = new List<string>();
List<string> mirroredPairs = new List<string>();
List<string> result = new List<string>();
Regex regex = new Regex(pattern);

foreach (Match match in regex.Matches(input))
{
    validPairs.Add(match.ToString());
}

for (int i = 0; i < validPairs.Count; i++)
{
    string firstHalf = validPairs[i].Substring(0, validPairs[i].Length / 2);
    string secondHalfReversed = "";

    for (int m = validPairs[i].Length - 1; m >= validPairs[i].Length / 2; m--)
    {
        secondHalfReversed += validPairs[i][m];
    }

    if (firstHalf == secondHalfReversed)
    {
        mirroredPairs.Add(validPairs[i]);
    }
}

foreach (var pair in mirroredPairs)
{
    string currentPair = pair.Substring(1, (pair.Length / 2) - 2);
    string currentPairOne = pair.Substring(pair.Length / 2 + 1, pair.Length - ((pair.Length / 2) + 2));
    result.Add($"{currentPair} <=> {currentPairOne}");
}

Console.WriteLine(validPairs.Count > 0 ? $"{validPairs.Count} word pairs found!" : "No word pairs found!");
Console.WriteLine(mirroredPairs.Count > 0 ? "The mirror words are:" : "No mirror words!");
Console.WriteLine(mirroredPairs.Count > 0 ? $"{string.Join(", ", result)}" : null);
