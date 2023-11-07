string durationOfContract = Console.ReadLine();
string contractType = Console.ReadLine();
string mobileInternet = Console.ReadLine();
int monthNum = int.Parse(Console.ReadLine());

double price = 0;

if (durationOfContract == "one")
{
    if (contractType == "Small")
    {
        price = 9.98;
    }
    else if (contractType == "Middle")
    {
        price = 18.99;
    }
    else if (contractType == "Large")
    {
        price = 25.98;
    }
    else if (contractType == "ExtraLarge")
    {
        price = 35.99;
    }
}
else if (durationOfContract == "two")
{
    if (contractType == "Small")
    {
        price = 8.58;
    }
    else if (contractType == "Middle")
    {
        price = 17.09;
    }
    else if (contractType == "Large")
    {
        price = 23.59;
    }
    else if (contractType == "ExtraLarge")
    {
        price = 31.79;
    }
}

if (mobileInternet == "yes")
{
    if (price <= 10.00)
    {
        price += 5.50;
    }
    else if (price <= 30.00)
    {
        price += 4.35;
    }
    else
    {
        price += 3.85;
    }
}
else if (mobileInternet == "no")
{
    price = price;
}

double totalPrice = price * monthNum;

if (durationOfContract == "two")
{
    totalPrice -= totalPrice * 0.0375;
}

Console.WriteLine($"{totalPrice:F2} lv.");