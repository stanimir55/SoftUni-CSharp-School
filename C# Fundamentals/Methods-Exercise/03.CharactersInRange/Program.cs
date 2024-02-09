char firstSymbol = char.Parse(Console.ReadLine());
char secondSymbol = char.Parse(Console.ReadLine());

if (secondSymbol < firstSymbol)
{
    for (int i = secondSymbol + 1; i < firstSymbol; i++)
    {
        PrintCharacters(i);
    }
}

for (int i = firstSymbol + 1; i < secondSymbol; i++)
{
    PrintCharacters(i);
}

static void PrintCharacters(int i)
{
    Console.Write($"{(char)i} ");
}