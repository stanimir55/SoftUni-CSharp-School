string seriesName = (Console.ReadLine());
int seriesTime = int.Parse(Console.ReadLine());
int lunchBreakTime = int.Parse(Console.ReadLine());

double timeForSeries = (double)lunchBreakTime * 5 / 8;

if (timeForSeries >= seriesTime)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - seriesTime)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
}
