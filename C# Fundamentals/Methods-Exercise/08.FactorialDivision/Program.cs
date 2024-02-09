double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

firstNumber = FindingFactorial(firstNumber);
secondNumber = FindingFactorial(secondNumber);

Console.WriteLine($"{firstNumber / secondNumber:F2}");

static double FindingFactorial(double number)
{
    for (int i = (int)number - 1; i >= 1; i--)
    {
        number *= i;
    }

    return number;
}