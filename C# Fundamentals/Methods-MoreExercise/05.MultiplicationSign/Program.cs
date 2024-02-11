decimal firstNumber = decimal.Parse(Console.ReadLine());
decimal secondNumber = decimal.Parse(Console.ReadLine());
decimal thirdNumber = decimal.Parse(Console.ReadLine());

PrintPositiveOrNegative(firstNumber, secondNumber, thirdNumber);

static void PrintPositiveOrNegative(decimal firstNumber, decimal secondNumber, decimal thirdNumber)
{
    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
    {
        Console.WriteLine("zero");
    }
    else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) ||
        (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
        (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) ||
        (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}

