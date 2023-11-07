using System.Reflection;

int examPoints = int.Parse(Console.ReadLine());
int homeWorkPercent = int.Parse(Console.ReadLine());

double total = examPoints + examPoints * homeWorkPercent / 100;
total = total / 100;
if (total > 6.00)
{
    total = 6.00;
}
else if (total > 2)
{
    total = 2.00;
    Console.WriteLine("There's no point!");
}
if (total < 4.00)
{
    Console.WriteLine($"{total:F2}");
    Console.WriteLine("It is recommended to repeat the course!");
}
if (total > 4.00)
{
    Console.WriteLine($"{total:F2}");
    Console.WriteLine("Enrollment in the Fundamentals Module course");
}