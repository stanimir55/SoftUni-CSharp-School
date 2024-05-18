Queue<int> cups = new Queue<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));
Stack<int> bottles = new Stack<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

int wastedLiters = 0;

while (cups.Any() && bottles.Any())
{
    int bootle = bottles.Pop();
    int cup = cups.Dequeue();
    cup -= bootle;

    while (cup > 0 && bottles.Any())
    {
        cup -= bottles.Pop();
    }

    if (cup < 0)
    {
        wastedLiters += cup;
    }
}

Console.WriteLine(cups.Count == 0 ? $"Bottles: {string.Join(" ", bottles)}" :
    $"Cups: {string.Join(" ", cups)}");
Console.WriteLine($"Wasted litters of water: {wastedLiters * -1}");
