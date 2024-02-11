string input = Console.ReadLine();

CheckInput(input);

static void CheckInput(string input)
{
    if (input == "int")
    {
        int number = int.Parse(Console.ReadLine()) * 2;
        Console.WriteLine(number);
    }
    else if (input == "real")
    {
        double number = double.Parse(Console.ReadLine()) * 1.5;
        Console.WriteLine($"{number:F2}");
    }
    else if (input == "string")
    {
        string text = Console.ReadLine();
        Console.WriteLine($"${text}$");
    }
}
