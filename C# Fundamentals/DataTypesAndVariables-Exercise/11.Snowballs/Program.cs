using System.Numerics;

int numberOfSnowballs = int.Parse(Console.ReadLine());

BigInteger maxSnowBallValue = 0;
int maxSnowBallSnow = 0;
int maxSnowBallTime = 0;
int maxSnowBallQuality = 0;
for (int i = 0; i < numberOfSnowballs; i++)
{
    int snowBallSnow = int.Parse(Console.ReadLine());
    int snowBallTime = int.Parse(Console.ReadLine());
    int snowBallQuality = int.Parse(Console.ReadLine());

    BigInteger snowBallValue = BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality);

    if (snowBallValue > maxSnowBallValue)
    {
        maxSnowBallValue = snowBallValue;
        maxSnowBallSnow = snowBallSnow;
        maxSnowBallTime = snowBallTime;
        maxSnowBallQuality = snowBallQuality;
    }
}

Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {maxSnowBallValue} ({maxSnowBallQuality})");