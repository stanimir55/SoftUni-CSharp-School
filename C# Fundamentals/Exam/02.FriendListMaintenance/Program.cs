List<string> allFriends = Console.ReadLine()
    .Split(", ")
    .ToList();
List<string> blackListed = new List<string>();
List<string> lostListed = new List<string>();

string commands;
while ((commands = Console.ReadLine()) != "Report")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "Blacklist":
            if (allFriends.Contains(arguments[1]))
            {
                Console.WriteLine($"{arguments[1]} was blacklisted.");
                blackListed.Add(arguments[1]);
                int indexOf = allFriends.IndexOf(arguments[1]);
                allFriends[indexOf] = "Blacklisted";
            }
            else
            {
                Console.WriteLine($"{arguments[1]} was not found.");
            }
            break;
        case "Error":
            int index = int.Parse(arguments[1]);

            if (index >= 0 && index < allFriends.Count)
            {
                string username = allFriends[index];
                if (username != "Blacklisted" && username != "Lost")
                {
                    if (!blackListed.Contains(username))
                    {
                        Console.WriteLine($"{username} was lost due to an error.");
                        lostListed.Add(username);
                        allFriends[index] = "Lost";
                    }
                }
            }
            break;
        case "Change":
            int changeIndex = int.Parse(arguments[1]);
            string newName = arguments[2];

            if (changeIndex >= 0 && changeIndex < allFriends.Count)
            {
                string currentName = allFriends[changeIndex];
                allFriends[changeIndex] = newName;
                Console.WriteLine($"{currentName} changed his username to {newName}.");
            }
            break;
    }
}

Console.WriteLine($"Blacklisted names: {blackListed.Count}");
Console.WriteLine($"Lost names: {lostListed.Count}");
Console.WriteLine(string.Join(" ", allFriends));