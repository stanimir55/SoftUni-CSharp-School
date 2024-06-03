List<string> names = Console.ReadLine()
    .Split()
    .ToList();
List<string> operations = new List<string>();

string commands;
while ((commands = Console.ReadLine()) != "Print")
{
    string[] arguments = commands.Split(";");
    string command = arguments[0];
    string filter = arguments[1];
    string value = arguments[2];

    if (command == "Add filter")
        operations.Add($"{filter};{value}");
    else
        operations.Remove($"{filter};{value}");
}

Func<List<string>, string, string, List<string>> filterNames
    = (names, operation, value) =>
    {
        return operation == "Starts with"
        ? names.Where(x => x.StartsWith(value)).ToList()
        : operation == "Ends with"
           ? names.Where(x => x.EndsWith(value)).ToList()
           : operation == "Contains"
              ? names.Where(x => x.Contains(value)).ToList()
              : names.Where(x => x.Length == int.Parse(value)).ToList();
    };

foreach (var item in operations)
{
    string[] arguments = item.Split(";");
    string operation = arguments[0];
    string value = arguments[1];

    List<string> filteredNames = filterNames(names, operation, value);
    names = names.Where(x => !filteredNames.Contains(x)).ToList();
}

Console.WriteLine(string.Join(" ", names));