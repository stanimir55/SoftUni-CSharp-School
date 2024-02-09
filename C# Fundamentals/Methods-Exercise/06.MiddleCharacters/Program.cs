string text = Console.ReadLine();
int lenght = text.Length / 2;

FoundMiddle(text, lenght);

static void FoundMiddle(string text, int lenght)
{
    if (text.Length % 2 == 0)
    {
        Console.WriteLine($"{text[lenght - 1]}{text[lenght]}");
    }
    else
    {
        Console.WriteLine(text[lenght]);
    }
}

