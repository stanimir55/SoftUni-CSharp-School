Predicate<string> checker = x => x[0] == x.ToUpper()[0];

List<string> text = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(x => checker(x))
    .ToList();

Console.WriteLine(string.Join(Environment.NewLine, text));
