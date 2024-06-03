List<string> namesList = Console.ReadLine()
    .Split()
    .Select(x => x
    .Insert(0, "Sir "))
    .ToList();

Action<List<string>> printNames = names
    => Console.WriteLine(string.Join(Environment.NewLine, names));

printNames(namesList);
