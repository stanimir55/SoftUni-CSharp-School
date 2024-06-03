List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Func<List<int>, string, List<int>> applyArithmetics
    = (numbers, operation) =>
    {
        return operation == "add"
        ? numbers.Select(x => x + 1).ToList()
        : operation == "multiply"
          ? numbers.Select(x => x * 2).ToList()
          : numbers.Select(x => x - 1).ToList();
    };

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    if (commands == "print")
        Console.WriteLine(string.Join(" ", numbers));
    else
        numbers = applyArithmetics(numbers, commands);
}