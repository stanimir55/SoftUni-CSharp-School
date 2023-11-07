int num = int.Parse(Console.ReadLine());
int pointsRank = int.Parse(Console.ReadLine());

string stage = "";

double pointsW = 0;
double pointsF = 0;
double pointsSf = 0;
double numW = 0;
for (int i = 1; i <= num; i++)
{
    stage = Console.ReadLine();
    if (stage == "W")
    {
        pointsW += 2000;
        numW++;
    }
    else if (stage == "F")
    {
        pointsF += 1200;
    }
    else if (stage == "SF")
    {
        pointsSf += 720;
    }
}

double percentWin = numW / num * 100;
double sumFromTour = pointsSf + pointsW + pointsF;
double finalPoints = pointsSf + pointsW + pointsF + pointsRank;
double averagePoints = Math.Floor(sumFromTour / num);

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{percentWin:F2}%");