double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

static double CalculateRectangleArea(double width, double height)
{
    return width * height;
}

Console.WriteLine(CalculateRectangleArea(width, height));