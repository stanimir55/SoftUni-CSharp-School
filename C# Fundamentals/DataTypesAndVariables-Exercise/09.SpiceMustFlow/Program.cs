int startingYield = int.Parse(Console.ReadLine());
int sum = 0;
int dayCounter = 0;

if (startingYield >= 100)
{
    while (startingYield >= 100)
    {
        int yield = startingYield;
        yield -= 26;
        startingYield -= 10;
        sum += yield;
        dayCounter++;
    }

    sum -= 26;

    Console.WriteLine(dayCounter);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine(dayCounter);
    Console.WriteLine(sum);
}
