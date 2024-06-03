List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Func<List<int>, int> getMinNumber = numbers
    => numbers.Min();

Console.WriteLine(getMinNumber(numbers));