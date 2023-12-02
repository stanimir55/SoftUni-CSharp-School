using System.Linq;

List<string> words = Console.ReadLine()
    .Split()
    .Where(w => w.Length % 2 == 0)
    .ToList();

Console.WriteLine(string.Join(Environment.NewLine, words));
