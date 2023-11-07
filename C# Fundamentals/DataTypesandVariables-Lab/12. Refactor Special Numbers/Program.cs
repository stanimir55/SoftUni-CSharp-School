int num = int.Parse(Console.ReadLine());
bool isSpecialNum = false;

for (int i = 1; i <= num; i++)
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
        isSpecialNum = true;
    }
    else
    {
        isSpecialNum = false;
    }

    Console.WriteLine($"{i} -> {isSpecialNum}");
}
