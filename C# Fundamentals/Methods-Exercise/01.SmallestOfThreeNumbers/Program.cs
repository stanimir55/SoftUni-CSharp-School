int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber < secondNumber && firstNumber < thirdNumber)
{
    PrintSmallNumber(firstNumber);
}
else if (secondNumber < firstNumber && secondNumber < thirdNumber)
{
    PrintSmallNumber(secondNumber);
}
else
{
    PrintSmallNumber(thirdNumber);
}

static void PrintSmallNumber(int number)
{
    Console.WriteLine(number);
}
