double moneyTereza = double.Parse(Console.ReadLine());
double moneyDay = double.Parse(Console.ReadLine());
double exprenses = double.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

double money = 5 * moneyTereza;
double totalMoney = 5 * moneyDay;
double totalSaveMoney = money + totalMoney - exprenses;

if (totalSaveMoney >= giftPrice)
{
    Console.WriteLine($"Profit: {totalSaveMoney:F2} BGN, the gift has been purchased.");
}
else if (totalSaveMoney < giftPrice)
{
    Console.WriteLine($"Insufficient money: {Math.Abs(totalSaveMoney - giftPrice):F2} BGN.");
}

