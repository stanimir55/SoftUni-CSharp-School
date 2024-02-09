string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split();
    string number = arguments[0];
    string reslult = "";
    FindPalindrome(number, ref reslult);

    if (number == reslult)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}

static void FindPalindrome(string number, ref string input)
{
    for (int i = number.Length - 1; i >= 0; i--)
    {
        input += number[i];
    }
}