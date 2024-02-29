List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
var numberCurrences = new SortedDictionary<int, int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (!numberCurrences.ContainsKey(numbers[i]))
    {
        numberCurrences[numbers[i]] = 1;
    }
    else
    {
        numberCurrences[numbers[i]]++;
    }
}

foreach (KeyValuePair<int, int> kvp in numberCurrences)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}