double wordRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

double recordByIvan = distance * timePerMeter;

double deleyTimes = Math.Floor(distance / 15);

recordByIvan = recordByIvan + deleyTimes * 12.5;

if (recordByIvan < wordRecord)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {recordByIvan:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(wordRecord - recordByIvan):F2} seconds slower.");
}

