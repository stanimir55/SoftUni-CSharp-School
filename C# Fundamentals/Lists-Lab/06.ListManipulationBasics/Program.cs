List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();
    int number = int.Parse(arguments[1]);

    switch (arguments[0])
    {
        case "Add":
            numbers.Add(number);
            break;
        case "Remove":
            numbers.Remove(number);
            break;
        case "RemoveAt":
            numbers.RemoveAt(number);
            break;
        case "Insert":
            int index = int.Parse(arguments[2]);
            numbers.Insert(index, number);
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
