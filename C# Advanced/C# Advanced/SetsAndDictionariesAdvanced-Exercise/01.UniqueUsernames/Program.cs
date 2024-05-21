int linesCount = int.Parse(Console.ReadLine());
HashSet<string> usernames = new HashSet<string>();

for (int i = 0; i < linesCount; i++)
{
    string username = Console.ReadLine();
    usernames.Add(username);
}

foreach (var username in usernames)
{
    Console.WriteLine(username);
}