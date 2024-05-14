Queue<string> childrenNames = new Queue<string>(Console.ReadLine().Split());
int tossCount = int.Parse(Console.ReadLine());
int tossesCounter = 0;

while (childrenNames.Count > 1)
{
    string childWithPotato = childrenNames.Dequeue();
    tossesCounter++;

    if (tossesCounter == tossCount)
    {
        tossesCounter = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    else
    {
        childrenNames.Enqueue(childWithPotato);
    }
}

Console.WriteLine($"Last is {childrenNames.Dequeue()}");
