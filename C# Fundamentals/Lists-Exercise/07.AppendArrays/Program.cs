string[] stringArrays = Console.ReadLine()
    .Split('|', StringSplitOptions.RemoveEmptyEntries);

List<string> symbols = ExtractSymbols(stringArrays);

Console.WriteLine(string.Join(" ", symbols));

List<string> ExtractSymbols(string[] stringArrays)
{
    List<string> result = new List<string>();

    for (int i = stringArrays.Length - 1; i >= 0; i--)
    {
        string item = stringArrays[i];

        string[] array = item.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        result.AddRange(array);
    }

    return result;
}