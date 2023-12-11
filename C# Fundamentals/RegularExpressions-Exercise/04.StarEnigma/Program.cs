using System.Text;
using System.Text.RegularExpressions;

int messagesCount = int.Parse(Console.ReadLine());

List<Message> messages = new List<Message>();

string starPattern = @"[SsTtAaRr]";
string messagesPattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>(?<soldires>\d+)";

for (int i = 0; i < messagesCount; i++)
{
    string encryptMessage = Console.ReadLine();
    int decryptionKey = Regex.Matches(encryptMessage, starPattern).Count;

    StringBuilder sb = new StringBuilder();

    for (int k = 0; k < encryptMessage.Length; k++)
    {
        sb.Append((char)(encryptMessage[k] - decryptionKey));
    }

    string decryptedMessage = sb.ToString();

    Match match = Regex.Match(decryptedMessage, messagesPattern);

    if (!Regex.IsMatch(decryptedMessage, messagesPattern))
    {
        continue;
    }


    Message message = new Message();
    message.PlanetName = match.Groups["planet"].Value;
    message.Population = uint.Parse(match.Groups["population"].Value);
    message.AttackType = match.Groups["type"].Value;
    message.SoliderCount = uint.Parse(match.Groups["soldires"].Value);

    messages.Add(message);
}

var filteredMessages = messages
    .Where(m => m.AttackType == "A")
    .OrderBy(m => m.PlanetName)
    .ToList();

Console.WriteLine($"Attacked planets: {filteredMessages.Count}");
filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

filteredMessages = messages
    .Where(m => m.AttackType == "D")
    .OrderBy(m => m.PlanetName)
    .ToList();

Console.WriteLine($"Destroyed planets: {filteredMessages.Count}");
filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));


class Message
{
    public string PlanetName { get; set; }

    public uint Population { get; set; }

    public string AttackType { get; set; }

    public uint SoliderCount { get; set; }

}