decimal numberOne = decimal.Parse(Console.ReadLine());
decimal numberTwo = decimal.Parse(Console.ReadLine());
decimal numberThree = decimal.Parse(Console.ReadLine());

PrintPositiveOrNegative(numberOne, numberTwo, numberThree);

static void PrintPositiveOrNegative(decimal numberOne, decimal numberTwo, decimal numberThree)
{
    if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
    {
        Console.WriteLine("zero");
    }
    else if ((numberOne > 0 && numberTwo > 0 && numberThree > 0) ||
        (numberOne < 0 && numberTwo < 0 && numberThree > 0) ||
        (numberOne < 0 && numberTwo > 0 && numberThree < 0) ||
        (numberOne > 0 && numberTwo < 0 && numberThree < 0))
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
