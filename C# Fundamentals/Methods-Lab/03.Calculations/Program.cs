string command = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

if (command == "add")
{
    Add(firstNumber, secondNumber);
}
else if (command == "multiply")
{
    Multiply(firstNumber, secondNumber);
}
else if (command == "subtract")
{
    Subtract(firstNumber, secondNumber);
}
else if (command == "divide")
{
    Divide(firstNumber, secondNumber);
}

static void Add(int a, int b)
{
    Console.WriteLine(a + b);
}
static void Multiply(int a, int b)
{
    Console.WriteLine(a * b);
}
static void Subtract(int a, int b)
{
    Console.WriteLine(a - b);
}
static void Divide(int a, int b)
{
    Console.WriteLine(a / b);
}