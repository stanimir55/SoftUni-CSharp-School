using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = $"(=|\\/)(?<location>[A-Z][A-Za-z]{{2,}})\\1";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

List<string> destinations = new List<string>();
int travelPoints = 0;

foreach (Match currentMatch in matches)
{
    travelPoints += currentMatch.Groups[2].Length;
    string currentDestination = currentMatch.Groups[2].Value;
    destinations.Add(currentDestination);
}


Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");

