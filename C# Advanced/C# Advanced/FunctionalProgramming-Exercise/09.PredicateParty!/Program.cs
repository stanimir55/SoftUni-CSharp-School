using System.IO;

List<string> names = Console.ReadLine()
    .Split()
    .ToList();

Func<List<string>, string, string, List<string>> removal
    = (listOfNames, operation, value) =>
    {
        return operation == "StartsWith"
        ? listOfNames.Where(x => x.StartsWith(value)).ToList()
        : operation == "EndsWith"
          ? listOfNames.Where(x => x.EndsWith(value)).ToList()
          : listOfNames.Where(x => x.Length == int.Parse(value)).ToList();
    };

string commands;
while ((commands = Console.ReadLine()) != "Party!")
{
    string[] arguments = commands.Split();
    string commandName = arguments[0];
    string operation = arguments[1];
    string value = arguments[2];

    List<string> targetNames = removal(names, operation, value);

    if (commandName == "Remove")
    {
        names = names.Where(x => !targetNames.Contains(x)).ToList();
    }
    else if (commandName == "Double")
    {
        for (int i = 0; i < targetNames.Count; i++)
        {
            int index = names.IndexOf(targetNames[i]);
            names.Insert(index, targetNames[i]);
        }
    }
}

Console.WriteLine(names.Count > 0 ? $"{string.Join(", ", names)} are going to the party!"
    : "Nobody is going to the party!");
