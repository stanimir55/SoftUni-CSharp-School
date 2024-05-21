int linesCount = int.Parse(Console.ReadLine());
Dictionary<int, int> numbers = new Dictionary<int, int>();

for (int i = 0; i < linesCount; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }

    numbers[number]++;

}

int evenNumber = numbers
    .Where(x => x.Value % 2 == 0)
    .FirstOrDefault()
    .Key;

Console.WriteLine(evenNumber);