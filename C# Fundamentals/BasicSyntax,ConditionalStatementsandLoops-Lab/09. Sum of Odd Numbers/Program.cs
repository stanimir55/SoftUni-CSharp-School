int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n * 2; i += 2)
{
    if (i % 2 == 1)
    {
        sum += i;
        Console.WriteLine(i);
    }
}

Console.WriteLine($"Sum: {sum}");