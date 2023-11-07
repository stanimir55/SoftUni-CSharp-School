int n = int.Parse(Console.ReadLine());
double price = 0;
double total = 0;

for (int i = 1; i <= n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    price = pricePerCapsule * days * capsulesCount;

    total += price;

    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}
if (n > 1)
{
    Console.WriteLine($"Total: ${total:F2}");
}
else
{
    Console.WriteLine($"Total: ${price:F2}");
}
