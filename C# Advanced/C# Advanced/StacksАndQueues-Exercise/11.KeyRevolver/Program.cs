int bulletPrice = int.Parse(Console.ReadLine());
int sizeOfGunBarrel = int.Parse(Console.ReadLine());
Stack<int> bullets = new Stack<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));
Queue<int> locks = new Queue<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));
int valueOfTheIntelligence = int.Parse(Console.ReadLine());

int shootsCount = 0;
int totalShoots = 0;

while (bullets.Any() && locks.Any())
{
    int currentBullet = bullets.Pop();
    int currentLock = locks.Peek();
    shootsCount++;
    totalShoots++;

    if (currentBullet <= currentLock)
    {
        locks.Dequeue();
        Console.WriteLine("Bang!");
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    if (shootsCount == sizeOfGunBarrel && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        shootsCount = 0;
    }
}

int moneyEarned = valueOfTheIntelligence - (bulletPrice * totalShoots);

Console.WriteLine(locks.Count > 0 ? $"Couldn't get through. Locks left: {locks.Count}" :
    $"{bullets.Count} bullets left. Earned ${moneyEarned}");
