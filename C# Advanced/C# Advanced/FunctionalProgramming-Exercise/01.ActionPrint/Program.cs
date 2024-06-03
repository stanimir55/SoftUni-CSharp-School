List<string> names = Console.ReadLine()
    .Split()
    .ToList();

Action <List<string>> printNames = allNames
    => Console.WriteLine(string.Join(Environment.NewLine, allNames));

printNames(names);