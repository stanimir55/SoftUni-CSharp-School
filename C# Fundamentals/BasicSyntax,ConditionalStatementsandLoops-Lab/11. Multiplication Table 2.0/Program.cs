int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int total = 0;

for (int i = 1; i <= 10; i++)
{
    if (k >= 1)
    {
        total = n * k;
        Console.WriteLine($"{n} X {k++} = {total}");
        if (k > 10)
        {
            break;
        }
    }
    if (k > 10)
    {
        total = n * k;
        Console.WriteLine($"{n} X {k} = {total}");
        break;
    }
}