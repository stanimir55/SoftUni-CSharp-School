string text = Console.ReadLine();
int number = int.Parse(Console.ReadLine());

static string RepeatString(string text, int number)
{
    string result = "";

    for (int i = 0; i < number; i++)
    {
        result += text;
    }

    return result;
}

Console.WriteLine(RepeatString(text, number));


//string text = Console.ReadLine();
//int number = int.Parse(Console.ReadLine());

//string result;

//for (int i = 0; i < number; i++)
//{
//    result = text;
//    Console.Write(result);
//}

