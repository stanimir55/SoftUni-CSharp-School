int age = int.Parse(Console.ReadLine());
double washinhMashine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int money = 0;

for (int birthday = 1; birthday <= age; birthday++)
{
    if (birthday % 2 == 0)
    {
        money += birthday * 5 - 1;
    }
    else
    {
        money += toyPrice;
    }
}

if (money >= washinhMashine)
{
    Console.WriteLine($"Yes! {money - washinhMashine:F2}");
}
else
{
    Console.WriteLine($"No! {Math.Abs(money - washinhMashine):F2}");
}