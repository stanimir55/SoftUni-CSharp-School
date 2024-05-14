int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> evenNumbers = new Queue<int>();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbers.Enqueue(numbers[i]);
    }
}

string result = "";
foreach (var number in evenNumbers)
{
    result += number + ", ";
}

Console.WriteLine(result.TrimEnd(' ', ','));
