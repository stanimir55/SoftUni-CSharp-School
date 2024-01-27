int kegsCount = int.Parse(Console.ReadLine());
decimal sum = 0;
string biggestKeg = "";

for (int i = 0; i < kegsCount; i++)
{
    string model = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    decimal currentResult = (decimal)Math.PI * (radius * radius) * height;

    if (currentResult > sum)
    {
        sum = currentResult;
        biggestKeg = model;
    }
}

Console.WriteLine(biggestKeg);
