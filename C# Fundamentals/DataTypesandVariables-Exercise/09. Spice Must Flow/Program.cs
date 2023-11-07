int startingYield = int.Parse(Console.ReadLine());

int consume = 0;
int days = 0;
int total = 0;

if (startingYield >= 100)
{
    while (startingYield >= 100)
    {
        days += 1;
        consume = startingYield;
        consume -= 26;

        if (days > 0)
        {
            startingYield -= 10;
        }

        total += consume;

    }

    total -= 26;

    if (startingYield <= 0)
    {
        total = 0;
    }

    Console.WriteLine(days);
    Console.WriteLine(total);
}
else
{
    Console.WriteLine(days);
    Console.WriteLine(total);
}