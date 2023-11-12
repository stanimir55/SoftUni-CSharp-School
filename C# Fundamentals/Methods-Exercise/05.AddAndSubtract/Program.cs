int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int sum = SumOfTheFirstTwoIntegers(firstNumber, secondNumber);

int totalSum = SubtractsTheThirdIntegerFromTheResult(thirdNumber, sum);

Console.WriteLine(totalSum);

static int SumOfTheFirstTwoIntegers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
static int SubtractsTheThirdIntegerFromTheResult(int thirdNumber, int sum)
{
    return sum - thirdNumber;
}

//int firstNumber = int.Parse(Console.ReadLine());
//int secondNumber = int.Parse(Console.ReadLine());
//int thirdNumber = int.Parse(Console.ReadLine());

//int sum = firstNumber + secondNumber;
//int totalSum = sum - thirdNumber;

//Console.WriteLine(totalSum);



