List<string> collectingItems = Console.ReadLine()
    .Split(", ")
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "Craft!")
{
    string[] arguments = commands.Split(" - ");

    switch (arguments[0])
    {
        case "Collect":
            if (!collectingItems.Contains(arguments[1]))
            {
                collectingItems.Add(arguments[1]);
            }
            break;
        case "Drop":
            collectingItems.Remove(arguments[1]);
            break;
        case "Combine Items":
            string[] _args;
            args = arguments[1].Split(":");
            int currentIndex = 0;
            string firstName = args[0];
            if (collectingItems.Contains(firstName))
            {
                for (int i = 0; i < collectingItems.Count; i++)
                {
                    if (collectingItems[i] == args[0])
                    {
                        currentIndex = i;
                    }
                }

                collectingItems.Insert(currentIndex + 1, args[1]);
            }
            break;
        case "Renew":
            if (collectingItems.Contains(arguments[1]))
            {
                collectingItems.Remove(arguments[1]);
                collectingItems.Add(arguments[1]);
            }
            break;
    }

}

Console.WriteLine(string.Join(", ", collectingItems));