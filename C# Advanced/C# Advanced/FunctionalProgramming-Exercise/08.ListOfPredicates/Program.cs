int n = int.Parse(Console.ReadLine());

List<int> numbers = Enumerable
    .Range(1, n)
    .ToList();

List<int> divides = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Func<int, List<int>, bool> isDivisibe = (number, divs)
    => divs.All(x => number % x == 0);

Console.WriteLine(string.Join(" ", numbers.Where(x => isDivisibe(x, divides))));
