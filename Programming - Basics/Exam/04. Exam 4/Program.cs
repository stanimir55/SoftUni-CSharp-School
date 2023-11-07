int dayNum = int.Parse(Console.ReadLine());

double totalLiters = 0;
double totalDegree = 0;

for (int i = 1; i <= dayNum; i++)
{
    double quantity = double.Parse(Console.ReadLine());
    double degree = double.Parse(Console.ReadLine());

    totalDegree += quantity * degree;
    totalLiters += quantity;

}

Console.WriteLine($"Liter: {totalLiters:F2}");
Console.WriteLine($"Degrees: {totalDegree / totalLiters:F2}");

double total = totalDegree / totalLiters;

if (total < 38)
{
    Console.WriteLine("Not good, you should baking!");
}
else if (total <= 42)
{
        Console.WriteLine("Super!");
}
else if (total > 42)
{
    Console.WriteLine("Dilution with distilled water!");
}
