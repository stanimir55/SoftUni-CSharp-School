List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;

while ((commands = Console.ReadLine()) != "end")
{
    string[] commandsTokens = commands.Split().ToArray();
    string command = commandsTokens[0];

    if (command == "Add")
    {
        int number = int.Parse(commandsTokens[1]);
        numbers.Add(number);
    }
    else if (command == "Remove")
    {
        int number = int.Parse(commandsTokens[1]);
        numbers.Remove(number);
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(commandsTokens[1]);
        numbers.RemoveAt(index);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(commandsTokens[1]);
        int index = int.Parse(commandsTokens[2]);
        numbers.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", numbers));