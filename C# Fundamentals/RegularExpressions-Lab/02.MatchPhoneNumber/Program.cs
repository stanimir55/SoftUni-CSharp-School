using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\+359([- ])2\1[\d]{3}\1[\d]{4}\b";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

string[] results = matches
    .Cast<Match>()
    .Select(a => a.Value.Trim())
    .ToArray();

Console.Write(string.Join(", ", results));
