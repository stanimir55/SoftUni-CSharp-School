using System.Drawing;

string figure = Console.ReadLine();
if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F3}");
}
else if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double area = sideA * sideB;
    Console.WriteLine($"{area:F3}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"{area:F3}");

}
else if (figure == "triangle")
{
    double sidaA = double.Parse(Console.ReadLine());
    double hightA = double.Parse(Console.ReadLine());
    double area = sidaA * hightA / 2;
    Console.WriteLine($"{area:F3}");

}