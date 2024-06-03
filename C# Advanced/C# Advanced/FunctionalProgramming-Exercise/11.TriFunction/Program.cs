int asciiSum = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine()
    .Split()
    .ToList();

Func<string, int, bool> filter = (name, sum)
    => name.Sum(x => x) >= sum;

Console.WriteLine(names.Where(x => filter(x, asciiSum)).First());