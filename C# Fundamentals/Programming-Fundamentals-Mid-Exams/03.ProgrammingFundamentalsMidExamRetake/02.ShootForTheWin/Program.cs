List<int> target = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command;
int counter = 0;

while ((command = Console.ReadLine()) != "End")
{
    int index = int.Parse(command);

    if (index < 0 || index >= target.Count || target[index] == -1)
    {
        index = int.Parse(command);
        continue;
    }

    int oldValue = target[index];
    target[index] = -1;
    counter++;

    for (int i = 0; i <= target.Count - 1; i++)
    {
        if (target[i] == -1)
        {
            continue;
        }

        if (oldValue < target[i])
        {
            int newValue = target[i] - oldValue;
            target[i] = newValue;
        }
        else if (oldValue >= target[i] && target[i] != - 1)
        {
            int newValue = oldValue + target[i];
            target[i] = newValue;
        }
    }
}

Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", target)}");
