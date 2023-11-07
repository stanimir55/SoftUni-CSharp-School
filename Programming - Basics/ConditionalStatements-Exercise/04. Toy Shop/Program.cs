double excursionPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

int total = puzzles + dolls + bears + minions + trucks;

double money = puzzles *2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

if (total >= 50)
{
    money = money - money * 0.25;
}

money = money - money * 0.1;

if (money >= excursionPrice)
{
    Console.WriteLine($"Yes! {money - excursionPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {excursionPrice - money:F2} lv needed.");
}