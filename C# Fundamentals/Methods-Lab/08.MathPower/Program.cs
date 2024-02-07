double firstNumber = double.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

PrintResult(firstNumber, secondNumber);

static void PrintResult(double firstNumber, int secondNumber)
{
    double result = Math.Pow(firstNumber, secondNumber);

    Console.WriteLine(result);
}
