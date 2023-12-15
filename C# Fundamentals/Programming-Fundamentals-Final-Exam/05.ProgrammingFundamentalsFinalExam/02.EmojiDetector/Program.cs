using System.Text.RegularExpressions;

string input = Console.ReadLine();
string numberPattern = @"(?<number>[0-9])";
string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";

Regex numberRegex = new Regex(numberPattern);
Regex emojiRegex = new Regex(emojiPattern);

MatchCollection numberMatches = numberRegex.Matches(input);
MatchCollection emojiMatches = emojiRegex.Matches(input);

List<int> numbers = new List<int>();

foreach (Match match in numberMatches)
{
    int currentNumber = int.Parse(match.ToString());
    numbers.Add(currentNumber);
}

int coolTotal = 0;

if (numbers.Count >= 2)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (i == 0)
        {
            coolTotal += numbers[i] * numbers[i + 1];
            i++;
        }
        else
        {
            coolTotal *= numbers[i];
        }
    }
}
else
{
    coolTotal = numbers.Sum();
}

var emojiList = new Dictionary<string, int>();

foreach (Match match in emojiMatches)
{
    string emoji = match.Groups["emoji"].ToString();
    char[] letters = emoji.ToCharArray();
    int number = letters.Sum(x => (int)x);
    string trueEmoji = match.ToString();

    if (!emojiList.ContainsKey(trueEmoji))
    {
        emojiList.Add(trueEmoji, number);
    }
}

Console.WriteLine($"Cool threshold: {coolTotal}");

if (emojiList.Any())
{
    Console.WriteLine($"{emojiList.Count} emojis found in the text. The cool ones are:");

    foreach (var (name, number) in emojiList)
    {
        if (number > coolTotal)
        {
            Console.WriteLine($"{name}");
        }
    }
}