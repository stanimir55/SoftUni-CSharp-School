string city = Console.ReadLine();
string packageType = Console.ReadLine();
string vip = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double price = 0;
if (days > 7)
{
    days -= 1;
}
if (city == "Bansko")
{
    if (packageType == "withEquipment")
    {
        price = days * 100;
        if (vip == "yes")
        {
            price = price - price * 0.10;
        }
    }
    else if (packageType == "noEquipment")
    {
        price = days * 80;
        if (vip == "yes")
        {
            price = price - price * 0.05;
        }
    }
}
else if (city == "Borovets")
{
    if (packageType == "withEquipment")
    {
        price = days * 100;
        if (vip == "yes")
        {
            price = price - price * 0.10;
        }
    }
    else if (packageType == "noEquipment")
    {
        price = days * 80;
        if (vip == "yes")
        {
            price = price - price * 0.05;
        }
    }
}
else if (city == "Varna")
{
    if (packageType == "withBreakfast")
    {
        price = days * 130;
        if (vip == "yes")
        {
            price = price - price * 0.12;
        }
    }
    else if (packageType == "noBreakfast")
    {
        price = days * 100;
        if (vip == "yes")
        {
            price = price - price * 0.07;
        }
    }
}
else if (city == "Burgas")
{
    if (packageType == "withBreakfast")
    {
        price = days * 130;
        if (vip == "yes")
        {
            price = price - price * 0.12;
        }
    }
    else if (packageType == "noBreakfast")
    {
        price = days * 100;
        if (vip == "yes")
        {
            price = price - price * 0.07;
        }
    }
}

if (days < 1)
{
    Console.WriteLine("Days must be positive number!");
}
else if (city != "Bansko" && city != "Borovets" && city !=  "Varna" && city != "Burgas")
{
    Console.WriteLine("Invalid input!");
}
else if (packageType != "noEquipment" && packageType!= "withEquipment" && packageType !="noBreakfast" && packageType != "withBreakfast")
{
    Console.WriteLine("Invalid input!");
}
else if (city == "Bansko" || city == "Borovets" || city == "Varna" || city == "Burgas")
{
    Console.WriteLine($"The price is {price:F2}lv! Have a nice time!");
}
