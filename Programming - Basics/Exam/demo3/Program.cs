int days = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string rate = Console.ReadLine();

days--;

double price = 0;

if (type == "room for one person")
{

    price = days * 18.00;

}
else if (type == "apartment")
{
    price = days * 25.00;
    if (days <= 10)
    {
        price -= price * 0.30;

    }
    else if (days <= 15)
    {
        price -= price * 0.35;

    }
    else if (days > 15)
    {
        price -= price * 0.50;

    }
}
else if (type == "president apartment")
{
    price = days * 35.00;
    if (days <= 10)
    {
        price -= price * 0.10;

    }
    else if (days <= 15)
    {
        price -= price * 0.15;

    }
    else if (days > 15)
    {
        price -= price * 0.20;

    }
}   
        
if (rate == "positive")
{
    price += price * 0.25;
}
else if (rate == "negative")
{
    price -= price * 0.10;
}

Console.WriteLine($"{price:F2}");



























