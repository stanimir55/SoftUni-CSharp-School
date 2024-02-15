List<int> targets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string commands;

while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();
    int index = int.Parse(arguments[1]);
    int value = int.Parse(arguments[2]);

    if (arguments[0] == "Shoot")
    {
        if (index >= 0 && index < targets.Count)
        {
            targets[index] -= value;

            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }
    }
    else if (arguments[0] == "Add")
    {
        if (index >= 0 && index < targets.Count)
        {
            targets.Insert(index, value);
        }
        else
        {
            Console.WriteLine("Invalid placement!");
        }
    }
    else if (arguments[0] == "Strike")
    {
        if (index >= 0 && index < targets.Count
            && index + value >= 0 && index + value < targets.Count
            && index - value >= 0 && index - value < targets.Count)
        {
            targets.RemoveAt(index);
            targets.RemoveAt(index - 1);
            targets.RemoveAt(index - 1);
        }
        else
        {
            Console.WriteLine("Strike missed!");
        }
    }
}

Console.WriteLine(string.Join("|", targets));