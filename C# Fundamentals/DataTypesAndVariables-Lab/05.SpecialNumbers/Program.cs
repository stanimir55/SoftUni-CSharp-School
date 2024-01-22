int n = int.Parse(Console.ReadLine());
bool isSpecialNumber = false;

for (int i = 1; i <= n; i++)
{
    int number = i;
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecialNumber = true;
    }
    else
    {
        isSpecialNumber = false;
    }

    Console.WriteLine($"{i} -> {isSpecialNumber}");
}