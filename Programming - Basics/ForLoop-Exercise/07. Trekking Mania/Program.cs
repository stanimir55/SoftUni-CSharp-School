int n = int.Parse(Console.ReadLine());

int num;
int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

int count = 0;

for (int i = 1; i <= n; i++)
{
    num = int.Parse(Console.ReadLine());

    count += num;

    if (num <= 5)
    {
        countP1 += num;
    }
    else if (num <= 12)
    {
        countP2 += num;
    }
    else if (num <= 25)
    {
        countP3 += num;
    }
    else if (num <= 40)
    {
        countP4 += num;
    }
    else
    {
        countP5 += num;
    }
}

Console.WriteLine($"{(double)countP1 / count * 100:F2}%");
Console.WriteLine($"{(double)countP2 / count * 100:F2}%");
Console.WriteLine($"{(double)countP3 / count * 100:F2}%");
Console.WriteLine($"{(double)countP4 / count * 100:F2}%");
Console.WriteLine($"{(double)countP5 / count * 100:F2}%");


