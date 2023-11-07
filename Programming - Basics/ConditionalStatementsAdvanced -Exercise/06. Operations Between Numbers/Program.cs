int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

if (operation == '+' || operation == '-' || operation == '*')
{
    int result = 0;

    if (operation == '+')
    {
        result = num1 + num2;
    }
    else if (operation == '-')
    {
        result = num1 - num2;
    }
    else
    {
        result = num1 * num2;
    }
    string evenOrOdd;
    if (result % 2 == 0)
    {
        evenOrOdd = "even";
    }
    else
    {
        evenOrOdd = "odd";
    }
    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
}
else
{
    if (num2 == 0)
        Console.WriteLine($"Cannot divide {num1} by zero");
    else if (operation == '/')
    Console.WriteLine($"{num1} / {num2} = {num1 / (double)num2:f2}");
    else
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
}

