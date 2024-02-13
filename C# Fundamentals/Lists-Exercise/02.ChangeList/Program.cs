List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();
    int element = int.Parse(arguments[1]);

    switch (arguments[0])
    {
        case "Delete":
            while (numbers.Contains(element) == true)
            {
                numbers.Remove(element);
            }
            break;
        case "Insert":
            int position = int.Parse(arguments[2]);
            numbers.Insert(position, element);
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));