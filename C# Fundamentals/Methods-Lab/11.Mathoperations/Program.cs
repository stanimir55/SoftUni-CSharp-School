double firstNumber = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
double secondNumber = int.Parse(Console.ReadLine());

if (command == "/")
{
    Calculate(firstNumber, command, secondNumber);
}
else if (command == "*")
{
    Calculate(firstNumber, command, secondNumber);
}
else if (command == "+")
{
    Calculate(firstNumber, command, secondNumber);
}
else if (command == "-")
{
    Calculate(firstNumber, command, secondNumber);
}

static double Calculate(double firstNumber, string command, double secondNumber)
{
    double result = 0;

    if (command == "/")
    {
        result = firstNumber / secondNumber;
    }
    else if (command == "*")
    {
        result = firstNumber * secondNumber;
    }
    else if (command == "+")
    {
        result = firstNumber + secondNumber;
    }
    else if (command == "-")
    {
        result = firstNumber - secondNumber;
    }

    Console.WriteLine(result);

    return result;
}