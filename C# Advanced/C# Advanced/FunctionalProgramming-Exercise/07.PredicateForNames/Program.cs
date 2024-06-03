int n = int.Parse(Console.ReadLine());


Func<string, int, bool> func = (name, length)
    => name.Length <= length;

List<string> names = Console.ReadLine()
    .Split()
    .Where(x => func(x, n))
    .ToList();
//.ForEach(Console.WriteLine);
Console.WriteLine(string.Join(Environment.NewLine, names));
