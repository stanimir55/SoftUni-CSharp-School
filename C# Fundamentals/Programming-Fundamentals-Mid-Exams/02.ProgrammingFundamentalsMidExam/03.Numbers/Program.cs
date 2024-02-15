List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] > (double)(numbers.Sum() / numbers.Count))
    {
        result.Add(numbers[i]);
    }
}

var sortedNumbers = result.OrderByDescending(x => x).ToList();

if (sortedNumbers.Count == 0)
{
    Console.WriteLine("No");
    return;
}

if (sortedNumbers.Count <= 5)
{
    Console.WriteLine(string.Join(" ", sortedNumbers));
}
else
{
    for (int i = 0; i <= 4; i++)
    {
        Console.Write(sortedNumbers[i] + " ");
    }
}
