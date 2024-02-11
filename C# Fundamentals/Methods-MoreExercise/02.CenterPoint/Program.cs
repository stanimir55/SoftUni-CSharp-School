double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double firstDistance = CalculateDistanceToZero(x1, y1);
double secondDistance = CalculateDistanceToZero(x2, y2);

if (firstDistance <= secondDistance)
{
    Console.WriteLine($"({x1}, {y1})");
}
else if (firstDistance > secondDistance)
{
    Console.WriteLine($"({x2}, {y2})");
}

static double CalculateDistanceToZero(double x, double y)
{
    return Math.Sqrt(x * x + y * y);
}