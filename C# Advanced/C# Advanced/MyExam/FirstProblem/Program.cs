Stack<int> packages = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> couriers = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int totalWeight = 0;

while (packages.Any() && couriers.Any())
{
    int currentPack = packages.Pop();
    int currentCourier = couriers.Dequeue();

    if (currentCourier >= currentPack)
    {
        if (currentCourier > currentPack)
        {
            currentCourier -= currentPack * 2;
        }
        else if (currentPack == currentCourier)
        {
            totalWeight += currentPack;
            continue;
        }

        if (currentCourier > 0)
        {
            couriers.Enqueue(currentCourier);
        }

    }
    else
    {
        currentPack -= currentCourier;
        packages.Push(currentPack);
        totalWeight += currentCourier;
        continue;
    }

    totalWeight += currentPack;
}

Console.WriteLine($"Total weight: {totalWeight} kg");

if (packages.Count == 0 && couriers.Count == 0)
{
    Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
}
else if (packages.Count > 0 && couriers.Count == 0)
{
    Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packages)}");
}
else if (couriers.Count > 0 && packages.Count == 0)
{
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
}
/*
2 4 6 8
8 6 4 2

7 14
2 2 2 1 7
 */