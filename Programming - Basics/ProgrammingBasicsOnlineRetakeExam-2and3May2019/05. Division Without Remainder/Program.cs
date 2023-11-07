int n = int.Parse(Console.ReadLine());

double counter1 = 0;
double counter2 = 0;
double counter3 = 0;

for (int i = 1; i <= n; i++)
{
    int k = int.Parse(Console.ReadLine());

    if (k % 2 == 0)
    {
        counter1++;
    }
    if (k % 3 == 0)
    {
        counter2++;
    }
    if (k % 4 == 0)
    {
        counter3++;
    }
}

double p1 = counter1 / n * 100;
double p2 = counter2 / n * 100;
double p3 = counter3 / n * 100;

Console.WriteLine($"{p1:F2}%");
Console.WriteLine($"{p2:F2}%");
Console.WriteLine($"{p3:F2}%");

