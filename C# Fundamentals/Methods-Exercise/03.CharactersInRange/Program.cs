char firstSymbol = char.Parse(Console.ReadLine());
char secondSymbol = char.Parse(Console.ReadLine());

char result = PrintsAllTheCharacters(firstSymbol, secondSymbol);

if (secondSymbol < firstSymbol)
{
    PrintsCharackters(firstSymbol, secondSymbol);
}

static char PrintsAllTheCharacters(char firstSymbol, char secondSymbol)
{
    for (int i = firstSymbol; i <= secondSymbol; i++)
    {
        for (int k = firstSymbol++; k < secondSymbol - 1; k++)
        {
            Console.Write(firstSymbol++ + " ");
        }
    }

    return firstSymbol;
}

static void PrintsCharackters(char firstSymbol, char secondSymbol)
{
    char[] swap = new char[2];
    swap[0] = secondSymbol;
    swap[1] = firstSymbol;

    for (int i = swap[0]; i < swap[1]; i++)
    {
        for (int k = swap[0]++; k < swap[1] - 1; k++)
        {
            Console.Write(swap[0]++ + " ");
        }
    }
}


//char firstSymbol = char.Parse(Console.ReadLine());
//char secondSymbol = char.Parse(Console.ReadLine());

//if (secondSymbol < firstSymbol)
//{
//    char[] swap = new char[2];
//    swap[0] = secondSymbol;
//    swap[1] = firstSymbol;

//    for (int i = swap[0]; i < swap[1]; i++)
//    {
//        for (int k = swap[0]++; k < swap[1] - 1; k++)
//        {
//            Console.Write(swap[0]++ + " ");
//        }
//    }
//}

//for (int i = firstSymbol; i <= secondSymbol; i++)
//{
//    for (int k = firstSymbol++; k < secondSymbol - 1; k++)
//    {
//        Console.Write(firstSymbol++ + " ");
//    }
//}