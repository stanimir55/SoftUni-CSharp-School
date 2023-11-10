int number = Math.Abs(int.Parse(Console.ReadLine()));

int evens = 0;
int odds = 0;

while (number > 0)
{
    int lastDigit = number % 10;

    evens = GetSumOfEvenDigits(number, evens, lastDigit);
    odds = GetSumOfOddDigits(number, odds, lastDigit);

    number /= 10;
}

GetMultipleOfEvenAndOdds(evens, odds);

static void GetMultipleOfEvenAndOdds(int evens, int odds)
{
    int result = evens * odds;

    Console.WriteLine(result);
}
static int GetSumOfEvenDigits(int number, int evens, int lastDigit)
{
    if (number % 2 == 0)
    {
        evens += lastDigit;
    }

    return evens;
}
static int GetSumOfOddDigits(int number, int odds, int lastDigit)
{
    if (number % 2 == 1)
    {
        odds += lastDigit;
    }

    return odds;
}


//int number = Math.Abs(int.Parse(Console.ReadLine()));

//int evens = 0;
//int odds = 0;

//while (number > 0)
//{
//    int lastDigit = number % 10;

//    if (number % 2 == 0)
//    {
//        evens += lastDigit;
//    }
//    else
//    {
//        odds += lastDigit;
//    }

//    number /= 10;
//}


//int result = evens * odds;

//Console.WriteLine(result);