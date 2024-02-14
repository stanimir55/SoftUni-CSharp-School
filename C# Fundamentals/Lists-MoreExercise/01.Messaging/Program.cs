List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<char> strings = new List<char>();

strings.AddRange(Console.ReadLine());

for (int i = 0; i < numbers.Count; i++)
{
    int sum = 0;

    while (numbers[i] != 0)
    {
        sum += numbers[i] % 10;
        numbers[i] /= 10;
    }

    int times = sum / strings.Count;
    sum = sum - times * strings.Count;

    Console.Write(strings[sum]);
    strings.RemoveAt(sum);
}
