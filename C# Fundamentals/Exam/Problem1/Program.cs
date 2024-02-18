int biscuitsProducedPerDayPerWorker = int.Parse(Console.ReadLine());
int workersCount = int.Parse(Console.ReadLine());
int biscuitsCountForOneMonth = int.Parse(Console.ReadLine());
double result = 0;

for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        result += Math.Floor(biscuitsProducedPerDayPerWorker * workersCount * 0.75);
        continue;
    }

    result += biscuitsProducedPerDayPerWorker * workersCount;
}

Console.WriteLine($"You have produced {result} biscuits for the past month.");

double percentage = Math.Abs(result - biscuitsCountForOneMonth) / biscuitsCountForOneMonth * 100;

if (result > biscuitsCountForOneMonth)
{
    Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
}
else
{
    Console.WriteLine($"You produce {percentage:F2} percent less biscuits.");
}