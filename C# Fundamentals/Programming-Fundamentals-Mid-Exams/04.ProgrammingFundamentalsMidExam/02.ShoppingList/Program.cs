List<string> initialList = Console.ReadLine()
    .Split('!')
    .ToList();

string commands;

while ((commands = Console.ReadLine()) != "Go Shopping!")
{
    string[] arguments = commands.Split();

    if (arguments[0] == "Urgent")
    {
        string item = arguments[1];

        if (initialList.Contains(item))
        {
            continue;
        }

        initialList.Insert(0, item);
    }
    else if (arguments[0] == "Unnecessary")
    {
        string item = arguments[1];

        if (initialList.Contains(item))
        {
            initialList.Remove(item);
        }
    }
    else if (arguments[0] == "Correct")
    {
        string oldItem = arguments[1];
        string newItem = arguments[2];

        if (initialList.Contains(oldItem))
        {
            for (int i = 0; i < initialList.Count; i++)
            {
                if (initialList[i] == oldItem)
                {
                    initialList.RemoveAt(i);
                    initialList.Insert(i, newItem);
                }
            }
        }
    }
    else if (arguments[0] == "Rearrange")
    {
        string item = arguments[1];

        if (initialList.Contains(item))
        {
            initialList.Remove(item);
            initialList.Add(item);
        }
    }
}

Console.WriteLine(string.Join(", ", initialList));

