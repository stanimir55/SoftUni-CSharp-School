int number = Math.Abs(int.Parse(Console.ReadLine()));
int evens = 0;
int odds = 0;

while (number > 0)
{
    int lastDigit = number % 10;

    if (number % 2 == 0)
    {
        evens = GetSumOfEvenDigits(evens, lastDigit);
    }
    else
    {
        odds = GetSumOfOddDigits(odds, lastDigit);
    }

    number /= 10;
}

int result = GetMultipleOfEvenAndOdds(evens, odds);

Console.WriteLine(result);

static int GetMultipleOfEvenAndOdds(int evens, int odds)
{
    return evens * odds;
}

static int GetSumOfOddDigits(int odds, int lastDigit)
{
    odds += lastDigit;
    return odds;
}

static int GetSumOfEvenDigits(int evens, int lastDigit)
{
    evens += lastDigit;
    return evens;
}