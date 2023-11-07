int tournamentsNum = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());

int pointsW = 0;
int pointsF = 0;
int pointsSF = 0;
double counter = 0;

for (int i = 1; i <= tournamentsNum; i++)
{
    string stage = Console.ReadLine();

    if (stage == "W")
    {
        counter++;
        pointsW += 2000;
    }
    else if(stage == "F")
    {
        pointsF += 1200;
    }
    else if (stage == "SF")
    {
        pointsSF += 720;
    }
}

double tournamentPoints = pointsW + pointsF + pointsSF;
double finalPoints = tournamentPoints + startPoints;
double averagePoints = Math.Floor(tournamentPoints / tournamentsNum);
double percentWin = counter / tournamentsNum * 100 ;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentWin:F2}%");
