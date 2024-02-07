double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

CalculateArea(width, height);

static void CalculateArea(double width, double height)
{
    Console.WriteLine(width * height);
}
