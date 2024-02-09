int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

Sum(firstNumber, secondNumber);
Subtract(firstNumber, secondNumber, thirdNumber);

Console.WriteLine(Subtract(firstNumber,secondNumber,thirdNumber));

static int Sum(int firstNumber, int secondNumber)
{
    int sum = firstNumber + secondNumber;

    return sum;
}
static int Subtract(int firstNumber, int secondNumber, int thirdNumber)
{
    int substract = Sum(firstNumber, secondNumber) - thirdNumber;

    return substract;
}
