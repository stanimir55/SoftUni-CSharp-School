List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
double leftRacerTime = 0;
double rightRacerTime = 0;

for (int i = 0; i < numbers.Count / 2; i++)
{
    leftRacerTime += numbers[i];

    if (numbers[i] == 0)
    {
        leftRacerTime *= 0.80;
    }
}
for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
{
    rightRacerTime += numbers[i];

    if (numbers[i] == 0)
    {
        rightRacerTime *= 0.80;
    }
}

if (leftRacerTime < rightRacerTime)
{
    Console.WriteLine($"The winner is left with total time: {leftRacerTime:#.#}");
}
else
{
    Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
}
