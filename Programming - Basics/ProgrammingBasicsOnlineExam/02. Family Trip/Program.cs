double budget = double.Parse(Console.ReadLine());
int nightNum = int.Parse(Console.ReadLine());
double nightPrice = double.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

if (nightNum > 7)
{
    double percentPrice = nightPrice * 0.05;
    nightPrice = nightPrice - percentPrice;
}

double totalNightPrice = nightPrice * nightNum;
double additionalCosts = budget * percent / 100;
double totalPrice = totalNightPrice + additionalCosts;

if (budget >= totalPrice)
{
    Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:F2} leva after vacation.");
}
else
{
    Console.WriteLine($"{Math.Abs(budget - totalPrice):F2} leva needed.");
}





