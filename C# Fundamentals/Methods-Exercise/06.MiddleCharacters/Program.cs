string str = Console.ReadLine();

if (str.Length % 2 == 0)
{
    Console.WriteLine(str.Substring((str.Length / 2) - 1, 2));
}
else
{
    Console.WriteLine(str[str.Length / 2]);
}


//string str = Console.ReadLine();

//PrintsTheCharacterFoundAtItsMiddle(str);

//static void PrintsTheCharacterFoundAtItsMiddle(string str)
//{
//    if (str.Length % 2 == 0)
//    {
//        Console.WriteLine(str.Substring((str.Length / 2) - 1, 2));
//    }
//    else
//    {
//        Console.WriteLine(str[str.Length / 2]);
//    }
//}

