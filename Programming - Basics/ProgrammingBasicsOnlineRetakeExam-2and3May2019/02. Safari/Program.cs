double budget = double.Parse(Console.ReadLine());
double litersFuel = double.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

double fuelPrice = litersFuel * 2.10;
double tourGuide = 100;

double totalPrice = fuelPrice + tourGuide;

if (dayOfWeek == "Saturday")
{
    totalPrice -= totalPrice * 0.10;
}
else if (dayOfWeek == "Sunday")
{
    totalPrice -= totalPrice * 0.20;
}

if (budget >= totalPrice)
{
    Console.WriteLine($"Safari time! Money left: {Math.Abs(totalPrice - budget):F2} lv. ");
}
else if (budget < totalPrice)
{
    Console.WriteLine($"Not enough money! Money needed: {Math.Abs(totalPrice - budget):F2} lv.");
}
