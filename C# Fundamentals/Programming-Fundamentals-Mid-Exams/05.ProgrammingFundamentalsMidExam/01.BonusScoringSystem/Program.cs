double studentsCount = double.Parse(Console.ReadLine());
double lecturesCountInCourse = double.Parse(Console.ReadLine());
double additionalBonus = double.Parse(Console.ReadLine());
int maxBonus = int.MinValue;
int maxAdditionalCount = int.MinValue;

if (studentsCount == 0 || lecturesCountInCourse == 0)
{
    Console.WriteLine($"Max Bonus: 0.");
    Console.WriteLine($"The student has attended 0 lectures.");
    return;
}

for (int i = 0; i < studentsCount; i++)
{
    int attendancesCount = int.Parse(Console.ReadLine());

    double bonus = Math.Ceiling((attendancesCount / lecturesCountInCourse) * (5 + additionalBonus));

    if (bonus >= maxBonus)
    {
        maxBonus = (int)bonus;
        maxAdditionalCount = attendancesCount;
    }
}

Console.WriteLine($"Max Bonus: {maxBonus}.");
Console.WriteLine($"The student has attended {maxAdditionalCount} lectures.");
