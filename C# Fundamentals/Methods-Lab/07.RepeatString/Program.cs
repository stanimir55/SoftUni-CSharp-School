string text = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
string result = "";

result = RepeatString(text, number, result);

static string RepeatString(string text, int number, string result)
{
    for (int i = 0; i < number; i++)
    {
        result += text;
    }

    Console.WriteLine(result);
    return result;
}