string drink = Console.ReadLine();
string sugar = Console.ReadLine();
int drinkNum = int.Parse(Console.ReadLine());

double price = 0;

if (drink == "Espresso")
{
    price = drinkNum * 0.90;
    if (sugar == "Without")
    {
        price = price - price * 0.35;
    }
    else if (sugar == "Normal")
    {
        price = drinkNum * 1.00;
    }
    else if (sugar == "Extra")
    {
        price = drinkNum * 1.20;
    }
    if (drinkNum >= 5)
    {
        price = price - price * 0.25;
    }
}
else if (drink == "Cappuccino")
{
    if (sugar == "Without")
    {
        price = drinkNum * 1.00;
        price = price - price * 0.35;
    }
    else if (sugar == "Normal")
    {
        price = drinkNum * 1.20;
    }
    else if (sugar == "Extra")
    {
        price = drinkNum * 1.60;
    }
}
else if (drink == "Tea")
{
    if (sugar == "Without")
    {
        price = drinkNum * 0.50;
        price = price - price * 0.35;
    }
    else if (sugar == "Normal")
    {
        price = drinkNum * 0.60;
    }
    else if (sugar == "Extra")
    {
        price = drinkNum * 0.70;
    }
}
if (price > 15)
{
    price = price - price * 0.2;
}

Console.WriteLine($"You bought {drinkNum} cups of {drink} for {price:F2} lv.");
