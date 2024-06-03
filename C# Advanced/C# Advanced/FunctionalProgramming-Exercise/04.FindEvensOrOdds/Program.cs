List<int> range = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> numbers = Enumerable
    .Range(range[0], range[1] - range[0] + 1)
    .ToList();

Predicate<int> isEven = x => x % 2 == 0;
Predicate<int> isOdd = x => x % 2 != 0;

string command = Console.ReadLine();

Console.WriteLine(command == "odd" ? string.Join(" ", numbers.FindAll(isOdd)) :
    string.Join(" ", numbers.FindAll(isEven)));