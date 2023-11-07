using System.Diagnostics;

int countOfPeople = int.Parse(Console.ReadLine());
string typeGroup = Console.ReadLine();
string day = Console.ReadLine();

if (typeGroup == "Business" && countOfPeople > 100)
{
    countOfPeople -= 10;
}

double priceForOnePeople = 0;

if (typeGroup == "Students")
{
    if (day == "Friday")
    {
        priceForOnePeople = 8.45;
    }
    else if (day == "Saturday")
    {
        priceForOnePeople = 9.80;
    }
    else if (day == "Sunday")
    {
        priceForOnePeople = 10.46;
    }
}
else if (typeGroup == "Business")
{
    if (day == "Friday")
    {
        priceForOnePeople = 10.90;
    }
    else if (day == "Saturday")
    {
        priceForOnePeople = 15.60;
    }
    else if (day == "Sunday")
    {
        priceForOnePeople = 16;
    }
}
else if (typeGroup == "Regular")
{
    if (day == "Friday")
    {
        priceForOnePeople = 15;
    }
    else if (day == "Saturday")
    {
        priceForOnePeople = 20;
    }
    else if (day == "Sunday")
    {
        priceForOnePeople = 22.50;
    }
}

double totalPrice = priceForOnePeople * countOfPeople;

if (typeGroup == "Students" && countOfPeople >= 30)
{
    totalPrice -= totalPrice * 0.15;
}
else if (typeGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
{
    totalPrice -= totalPrice * 0.05;
}

Console.WriteLine($"Total price: {totalPrice:F2}");