int gameNum = int.Parse(Console.ReadLine());

int hearthstone = 0;
int fornite = 0;
int overwatch = 0;
int others = 0;

for (int i = 1; i <= gameNum; i++)
{
    string gameName = Console.ReadLine();

    if (gameName == "Hearthstone")
    {
        hearthstone++;
    }
    else if (gameName == "Fornite")
    {
        fornite++;
    }
    else if (gameName == "Overwatch")
    {
        overwatch++;
    }
    if (gameName != "Hearthstone" && gameName != "Fornite" && gameName != "Overwatch")
    {
        others++;
    }
}

double hearthstonePercent = hearthstone * 1.0 / gameNum * 100;
double fornitePercent = fornite * 1.0 / gameNum * 100;
double overwatchPercent = overwatch * 1.0 / gameNum * 100;
double othersPercent = others * 1.0 / gameNum * 100;

Console.WriteLine($"Hearthstone - {hearthstonePercent:F2}%");
Console.WriteLine($"Fornite - {fornitePercent:F2}%");
Console.WriteLine($"Overwatch - {overwatchPercent:F2}%");
Console.WriteLine($"Others - {othersPercent:F2}%");