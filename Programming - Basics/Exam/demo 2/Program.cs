double tShortPrice = double.Parse(Console.ReadLine());
double priseForBall= double.Parse(Console.ReadLine());

double shot = tShortPrice * 0.75;
double ch = shot * 0.20;
double buttons = (shot + tShortPrice) * 2;

double total = tShortPrice + shot + ch + buttons;
double totalPercent = total - total * 0.15;

if (totalPercent >= priseForBall)
{
    Console.WriteLine($"His sum is {totalPercent:F2} lv.");
}
else
{
    Console.WriteLine($"He needs {Math.Abs(totalPercent - priseForBall):F2} lv. more.");
}























