int kegsCount = int.Parse(Console.ReadLine());

string biggestKegModel = "";
decimal biggestKegVolume = 0;

for (int i = 1; i <= kegsCount; i++)
{
    string kegModel = Console.ReadLine();
    decimal kegRadius = decimal.Parse(Console.ReadLine());
    decimal kegHeight = decimal.Parse(Console.ReadLine());

    decimal volume = (decimal)Math.PI * (kegRadius * kegRadius) * kegHeight;

    if (volume > biggestKegVolume)
    {
        biggestKegVolume = volume;
        biggestKegModel = kegModel;
    }
}

Console.WriteLine(biggestKegModel);