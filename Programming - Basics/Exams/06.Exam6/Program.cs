int locationNum = int.Parse(Console.ReadLine());

double counter = 0;
double average = 0;
for (int i = 1; i <= locationNum; i++)
{
    double averageGold = double.Parse(Console.ReadLine());
    int daysNum = int.Parse(Console.ReadLine());

    for (int n = 1; n <= daysNum; n++)
    {
        double gold = double.Parse(Console.ReadLine());
        counter += gold;
        average = counter / daysNum;
    }
    if (averageGold <= average)
    {
        Console.WriteLine($"Good job! Average gold per day: {average:F2}.");
    }
    else if (averageGold > average)
    {
        Console.WriteLine($"You need {Math.Abs(averageGold - average):F2} gold.");
    }
    averageGold = 0;
    average = 0;
    counter = 0;
}










