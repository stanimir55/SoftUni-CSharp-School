using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(#|\|)([A-Za-z ]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d+)\1";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
int totalCalories = 0;

foreach (Match match in matches)
{
    totalCalories += int.Parse(match.Groups[4].Value);
}

double totalDays = totalCalories / 2000;

Console.WriteLine($"You have food to last you for: {totalDays} days!");

foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[4].Value}");
}
