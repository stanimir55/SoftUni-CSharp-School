double profitClub = double.Parse(Console.ReadLine());
string cocktailName = Console.ReadLine();

double nightMoney = 0.00;
double totalPrice = 0.00;

while (cocktailName != "Party!")
{
    int cocktailNum = int.Parse(Console.ReadLine());
    double cocktailPrice = cocktailName.Length;
    totalPrice = cocktailPrice * cocktailNum;

    if (totalPrice % 2 == 1)
    {
        totalPrice = totalPrice - totalPrice * 0.25;

    }

    nightMoney += totalPrice;

    if (nightMoney >= profitClub)
    {
        Console.WriteLine("Target acquired.");
        break;
    }
    cocktailName = Console.ReadLine();

    if (cocktailName == "Party!")
    {
        Console.WriteLine($"We need {profitClub - nightMoney:F2} leva more.");
    }
}

Console.WriteLine($"Club income - {nightMoney:F2} leva.");
