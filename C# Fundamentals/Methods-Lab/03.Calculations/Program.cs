string command = Console.ReadLine();
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

static void Add(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne + numberTwo);
}

static void Multiply(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne * numberTwo);
}

static void Subtract(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne - numberTwo);
}

static void Divide(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne / numberTwo);
}

switch (command)
{
    case "add":
        Add(numberOne, numberTwo);
            break;
    case "multiply":
        Multiply(numberOne, numberTwo);
        break;
    case "subtract":
        Subtract(numberOne, numberTwo);
        break;
    case "divide":
        Divide(numberOne, numberTwo);
        break;
}
//if (command == "add")
//{
//    Console.WriteLine(numberOne + numberTwo);
//}
//else if (command == "multiply")
//{
//    Console.WriteLine(numberOne * numberTwo);
//}
//else if (command == "subtract")
//{
//    Console.WriteLine(numberOne - numberTwo);
//}
//else if (command == "divide")
//{
//    Console.WriteLine(numberOne / numberTwo);
//}
