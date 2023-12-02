int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var numberCurrences = new SortedDictionary<int, int>();

for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = numbers[i];

    if (!numberCurrences.ContainsKey(numbers[i]))
    {
        numberCurrences[currentNumber] = 1;
    }
    else
    {
        numberCurrences[currentNumber]++;
    }
}

foreach (KeyValuePair<int,int> kvp in numberCurrences)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}