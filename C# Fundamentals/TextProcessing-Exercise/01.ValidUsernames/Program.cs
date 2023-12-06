List<string> usernames = Console.ReadLine()
    .Split(", ")
    .ToList();

for (int i = 0; i < usernames.Count; i++)
{
    if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
    {
        bool validUsernames = ValidUserNames(usernames[i]);

        if (validUsernames == true)
        {
            Console.WriteLine(usernames[i]);
        }
    }
}

static bool ValidUserNames(string user)
{
    foreach (var symbol in user)
    {
        if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
        {
            continue;
        }
        else
        {
            return false;
        }
    }

    return true;
}