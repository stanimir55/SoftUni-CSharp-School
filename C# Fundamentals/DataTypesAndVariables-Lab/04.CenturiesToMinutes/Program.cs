﻿int centuries = int.Parse(Console.ReadLine());

int years = centuries * 100;
int days = (int)(years * 365.2422);
int hours = days * 24;
int minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes");