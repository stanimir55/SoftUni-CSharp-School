string command = Console.ReadLine();

IfTypeIsInt(command);

IfTypeIsReal(command);

IfTypeIsString(command);

static void IfTypeIsInt(string command)
{
    if (command == "int")
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number * 2);
    }
}

static void IfTypeIsReal (string command)
{
    if (command == "real")
    {
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine($"{number * 1.5:F2}");
    }
}

static void IfTypeIsString(string command)
{
    if (command == "string")
    {
        string str = Console.ReadLine();

        Console.WriteLine($"${str}$");
    }
}