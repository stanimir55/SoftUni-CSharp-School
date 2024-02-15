int people = int.Parse(Console.ReadLine());
List<int> currentLift = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < currentLift.Count; i++)
{
    for (int k = 1; k <= people; k++)
    {
        if (currentLift[i] < 4)
        {
            while (true)
            {
                if (people == 0)
                {
                    break;
                }
                currentLift[i] += k;
                people -= k;
                if (currentLift[i] == 4)
                {
                    break;
                }
            }
        }
    }
}
for (int i = 0; i < currentLift.Count; i++)
{
    if (currentLift[i] < 4 && people == 0)
    {
        Console.WriteLine("The lift has empty spots!");
        PrintsWagons(currentLift);
        return;
    }
    if (people > 0 && currentLift[i] == 4)
    {
        Console.WriteLine($"There isn't enough space! {people} people in a queue!");
        PrintsWagons(currentLift);
        return;
    }
}

PrintsWagons(currentLift);

static void PrintsWagons(List<int> currentLift)
{
    Console.WriteLine(string.Join(" ", currentLift));
}