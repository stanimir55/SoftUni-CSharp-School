int linesCount = int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < linesCount; i++)
{
    string[] input = Console.ReadLine().Split();

    for (int k = 0; k < input.Length; k++)
    {
        elements.Add(input[k]);
    }
}

Console.WriteLine(string.Join(" ", elements));