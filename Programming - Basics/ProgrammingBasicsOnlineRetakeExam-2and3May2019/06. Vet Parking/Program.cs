int daysNum = int.Parse(Console.ReadLine());
int hoursNum = int.Parse(Console.ReadLine());

double parkingPrice = 0;

for (int day = 1; day <= daysNum; day++)
{
    double dayPrice = 0;

    for (int hour = 1; hour <= hoursNum; hour++)
    {
        if (day % 2 == 0 && hour % 2 == 1)
        {
            parkingPrice += 2.50;
            dayPrice += 2.50;
        }
        else if (day % 2 == 1 && hour % 2 == 0)
        {
            parkingPrice += 1.25;
            dayPrice += 1.25;
        }
        else
        {
            parkingPrice += 1;
            dayPrice += 1;
        }
    }

    Console.WriteLine($"Day: {day} - {dayPrice:F2} leva");
}

Console.WriteLine($"Total: {parkingPrice:F2} leva");



