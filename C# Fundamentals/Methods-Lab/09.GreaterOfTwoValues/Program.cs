string type = Console.ReadLine();

static int GetMax(int numberOne, int numberTwo)
{
    if (numberOne > numberTwo)
    {
        Console.WriteLine(numberOne);
        return numberOne;
    }
    else
    {
        Console.WriteLine(numberTwo);
        return numberTwo;
    }
}

static char GetMaxx(char symbolOne, char symbolTwo)
{
    if (symbolOne > symbolTwo)
    {
        Console.WriteLine(symbolOne);
        return symbolOne;
    }
    else
    {
        Console.WriteLine(symbolTwo);
        return symbolTwo;
    }
}

static string GetMaxxx(string strOne, string strTwo)
{
    if (strOne.CompareTo(strTwo) > strTwo.CompareTo(strOne))
    {
        Console.WriteLine(strOne);
        return strOne;
    }
    else
    {
        Console.WriteLine(strTwo);
        return strTwo;
    }
}

if (type == "int")
{
    int numberOne = int.Parse(Console.ReadLine());
    int numberTwo = int.Parse(Console.ReadLine());
    GetMax(numberOne, numberTwo);
}
else if (type == "char")
{
    char symbolOne = char.Parse(Console.ReadLine());
    char symbolTwo = char.Parse(Console.ReadLine());

    GetMaxx(symbolOne, symbolTwo);
}
else if (type == "string")
{
    string strOne = Console.ReadLine();
    string strTwo = Console.ReadLine();

    GetMaxxx(strOne, strTwo);
}


//string type = Console.ReadLine();

//if (type == "int")
//{
//    int numberOne = int.Parse(Console.ReadLine());
//    int numberTwo = int.Parse(Console.ReadLine());

//    if (numberOne > numberTwo)
//    {
//        Console.WriteLine(numberOne);
//    }
//    else
//    {
//        Console.WriteLine(numberTwo);
//    }
//}
//else if (type == "char")
//{
//    char symbolOne = char.Parse(Console.ReadLine());
//    char symbolTwo = char.Parse(Console.ReadLine());

//    if (symbolOne > symbolTwo)
//    {
//        Console.WriteLine(symbolOne);
//    }
//    else
//    {
//        Console.WriteLine(symbolTwo);
//    }
//}
//else if (type == "string")
//{
//    string strOne = Console.ReadLine();
//    string strTwo = Console.ReadLine();

//    if (strOne.CompareTo(strTwo) > strTwo.CompareTo(strOne))
//    {
//        Console.WriteLine(strOne);
//    }
//    else
//    {
//        Console.WriteLine(strTwo);
//    }
//}