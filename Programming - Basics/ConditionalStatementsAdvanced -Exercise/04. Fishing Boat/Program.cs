int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishingMan = int.Parse(Console.ReadLine());

double price;

switch (season)
{
    case "Spring":
        price = 3000;
        break;
    case "Summer":
    case "Autumn":
        price = 4200;
        break;
    default:
        price = 2600;
        break;
}

if (fishingMan <= 6)
price = price - price * 0.1;
else if (fishingMan <=11)
price = price - price * 0.15;
else
price = price - price * 0.25;

if (fishingMan % 2 == 0 && season != "Autumn")
price = price - price * 0.05;

if (price <= budget)
{
    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva."
);
}
