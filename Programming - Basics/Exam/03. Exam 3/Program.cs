int dancersNum = int.Parse(Console.ReadLine());
double pointsNum = double.Parse(Console.ReadLine());
string seoson = Console.ReadLine();
string place = Console.ReadLine();

double money = 0;

if (place == "Bulgaria")
{
    money = pointsNum * dancersNum;
    if (seoson == "summer")
    {
        money -= money * 0.05;
    }
    else if (seoson == "winter")
    {
        money -= money * 0.08;
    }
}
else if (place == "Abroad")
{
    money = pointsNum * dancersNum;
    money = money + money / 2;
    if (seoson == "summer")
    {
        money -= money * 0.10;
    }
    else if (seoson == "winter")
    {
        money -= money * 0.15;
    }
}

double moneyCharity = money * 0.75;
money = money - moneyCharity;

double moneyPerDancer = money / dancersNum;

Console.WriteLine($"Charity - {moneyCharity:F2}");
Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
