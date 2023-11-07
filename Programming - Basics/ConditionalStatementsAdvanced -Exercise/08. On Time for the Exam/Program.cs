int examTime = int.Parse(Console.ReadLine());
int minuteExam = int.Parse(Console.ReadLine());
int arrivalTime = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examHoursMin = examTime * 60;
int hoursInMin = arrivalTime * 60;

int totalExamTime = examHoursMin + minuteExam;
int totalArrivelTime = hoursInMin + arrivalMinute;

int diff = totalExamTime - totalArrivelTime;

if (diff > 30)
{
    Console.WriteLine("Early");
    if (diff > 59)
    {
        Console.WriteLine($"{diff / 60}:{diff % 60:D2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{diff} minutes before the start");
    }
}
else if (diff <= 30 && diff >= 0)
{
    Console.WriteLine("On time");
    Console.WriteLine($"{diff} minutes before the start");
}
else
{
    diff *= -1;
    Console.WriteLine("Late");
    if (diff > 59)
    {
        Console.WriteLine($"{Math.Abs(arrivalTime - examTime)}:{Math.Abs(arrivalMinute - minuteExam):D2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{diff} minutes after the start");
    }
}
