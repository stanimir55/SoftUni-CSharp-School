﻿int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 30;

if (minutes > 60)
{
    minutes -= 60;
    hours++;
}
if (hours == 24)
{
    hours = 0;
}

Console.WriteLine($"{hours}:{minutes:D2}");