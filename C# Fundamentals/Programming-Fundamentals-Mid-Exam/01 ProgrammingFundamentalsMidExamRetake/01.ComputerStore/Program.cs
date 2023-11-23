string client = Console.ReadLine();
double taxes = 0;
double totalPrice = 0;
double priceWithoutTaxes = 0;

while (client != "special" && client != "regular")
{
    double price = double.Parse(client);

    if (price < 0)
    {
        Console.WriteLine("Invalid price!");
    }
    else if (price > 0)
    {
        priceWithoutTaxes += price;
        taxes += price * 0.20;
    }

    client = Console.ReadLine();
}

totalPrice += priceWithoutTaxes + taxes;

if (client == "special")
{
    totalPrice -= totalPrice * 0.10;
}

if (totalPrice == 0)
{
    Console.WriteLine("Invalid order!");
    return;
}

Console.WriteLine("Congratulations you've just bought a new computer!");
Console.WriteLine($"Price without taxes: {priceWithoutTaxes:F2}$");
Console.WriteLine($"Taxes: {taxes:F2}$");
Console.WriteLine("-----------");
Console.WriteLine($"Total price: {totalPrice:F2}$");


