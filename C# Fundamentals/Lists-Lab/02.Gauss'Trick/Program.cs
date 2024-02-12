List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    int firstNumber = numbers[i];
    int lastNumber = numbers[numbers.Count - i - 1];
    result.Add(firstNumber + lastNumber);
}

if (numbers.Count % 2  == 1)
{
    result.Add(numbers[numbers.Count / 2]);
}
Console.WriteLine(string.Join(" ", result));