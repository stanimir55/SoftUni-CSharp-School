using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine().ToUpper();
string pattern = @"(?<letters>[\D]+)(?<numbers>[0-9]+)";

MatchCollection matches = Regex.Matches(input, pattern);
StringBuilder sb = new StringBuilder();

foreach (Match match in matches)
{
    string letters = match.Groups["letters"].Value;
    int number = int.Parse(match.Groups["numbers"].Value);

    for (int i = 0; i < number; i++)
    {
        sb.Append(letters);
    }
}

int symbolsCount = sb.ToString().Distinct().Count();

Console.WriteLine($"Unique symbols used: {symbolsCount}");
Console.WriteLine($"{sb}");
