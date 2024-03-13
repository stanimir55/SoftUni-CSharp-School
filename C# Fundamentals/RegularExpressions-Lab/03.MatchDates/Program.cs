using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(?<day>\d{2})([\.|\-|\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    //var day = match.Groups["day"].Value;
    //var month = match.Groups["month"].Value;
    //var year = match.Groups["year"].Value;
    Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
    //Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}

