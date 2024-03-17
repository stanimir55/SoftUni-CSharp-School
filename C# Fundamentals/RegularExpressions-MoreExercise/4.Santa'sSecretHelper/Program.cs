using System.Text.RegularExpressions;

int key = int.Parse(Console.ReadLine());
string command;

string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[G])!";
Regex regex = new Regex(pattern);
List<string> names = new List<string>();

while ((command = Console.ReadLine()) != "end")
{
    string strAfterDecrypt = "";

    for (int i = 0; i < command.Length; i++)
    {
        int chekLetter = command[i] - key;
        char decryptLetter = (char)chekLetter;
        strAfterDecrypt += decryptLetter;
    }

    if (regex.IsMatch(strAfterDecrypt))
    {
        names.Add(regex.Match(strAfterDecrypt).Groups["name"].Value);
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
