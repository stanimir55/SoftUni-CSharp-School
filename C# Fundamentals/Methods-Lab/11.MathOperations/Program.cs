double firstNumber = double.Parse(Console.ReadLine());
string command = Console.ReadLine();
double secondNumber = double.Parse(Console.ReadLine());

Calculate(firstNumber, command, secondNumber);

static void Calculate(double firstNumber, string command, double secondNumber)
{
    switch (command)
    {
        case "+":
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case "-":
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case "*":
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case "/":
            Console.WriteLine(firstNumber / secondNumber);
            break;
    }
}
