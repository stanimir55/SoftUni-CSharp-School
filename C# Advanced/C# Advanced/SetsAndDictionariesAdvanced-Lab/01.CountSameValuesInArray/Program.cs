List<double> numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();
Dictionary<double, int> numbersCount = new Dictionary<double, int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (!numbersCount.ContainsKey(numbers[i]))
    {
        numbersCount.Add(numbers[i], 0);
    }

    numbersCount[numbers[i]]++;
}

foreach (var kvp in numbersCount)
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
}