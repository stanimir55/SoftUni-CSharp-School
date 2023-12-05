string str = Console.ReadLine();

string digits = "";
string letters = "";
string otherCharacters = "";

for (int i = 0; i < str.Length; i++)
{
    if (char.IsDigit(str[i]))
    {
        digits += str[i];
    }
    else if (char.IsLetter(str[i]))
    {
        letters += str[i];
    }
    else
    {
        otherCharacters += str[i];
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherCharacters);