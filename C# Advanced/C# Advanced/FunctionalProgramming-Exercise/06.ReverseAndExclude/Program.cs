List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int n = int.Parse(Console.ReadLine());

Func<int, int, bool> fiter = (number, div)
    => number % div == 0;

Console.WriteLine(string.Join(" ", numbers
    .Where(x => !fiter(x, n))
    .Reverse()));