double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

PrintClosestPointToZero(x1, y1, x2, y2);

static void PrintClosestPointToZero(double x1, double y1, double x2, double y2)
{
    double distanceOne = CalculateDistanceToZero(x1, y1);
    double distanceTwo = CalculateDistanceToZero(x2, y2);

    if (distanceOne < distanceTwo)
    {
        Console.WriteLine($"({x1}, {y1})");
    }
    else if (distanceTwo < distanceOne)
    {
        Console.WriteLine($"({x2}, {y2})");
    }
    else
    {
        Console.WriteLine($"({x1}, {y1})");
    }
}

static double CalculateDistanceToZero(double x, double y)
{
    return Math.Sqrt(x * x + y * y);
}

