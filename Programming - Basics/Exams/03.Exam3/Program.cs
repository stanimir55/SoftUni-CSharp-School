string month = Console.ReadLine();
int hoursNum = int.Parse(Console.ReadLine());
int peopleGroupNum = int.Parse(Console.ReadLine());
string dayOrNight = Console.ReadLine();

double price = 0;
double priceOneHour = 0;

if (month == "march" || month == "april" || month == "may")
{
    if (dayOrNight == "day")
    {
        priceOneHour = 10.50;

        if (peopleGroupNum >= 4)
        {
            priceOneHour -= priceOneHour * 0.10;
        }
        if (hoursNum >= 5)
        {
            priceOneHour -= priceOneHour * 0.50;
        }

        price = hoursNum * priceOneHour * peopleGroupNum;
    }
    else if (dayOrNight == "night")
    {
        priceOneHour = 8.40;

        if (peopleGroupNum >= 4)
        {
            priceOneHour -= priceOneHour * 0.10;
        }
        if (hoursNum >= 5)
        {
            priceOneHour -= priceOneHour * 0.50;
        }

        price = hoursNum * priceOneHour * peopleGroupNum;
    }
}
else if (month == "june" || month == "july" || month == "august")
{
    if (dayOrNight == "day")
    {
        priceOneHour = 12.60;

        if (peopleGroupNum >= 4)
        {
            priceOneHour -= priceOneHour * 0.10;
        }
        if (hoursNum >= 5)
        {
            priceOneHour -= priceOneHour * 0.50;
        }

        price = hoursNum * priceOneHour * peopleGroupNum;
    }
    else if (dayOrNight == "night")
    {
        priceOneHour = 10.20;

        if (peopleGroupNum >= 4)
        {
            priceOneHour -= priceOneHour * 0.10;
        }
        if (hoursNum >= 5)
        {
            priceOneHour -= priceOneHour * 0.50;
        }

        price = hoursNum * priceOneHour * peopleGroupNum;
    }
}

Console.WriteLine($"Price per person for one hour: {priceOneHour:F2}");
Console.WriteLine($"Total cost of the visit: {price:F2}");


