string input = Console.ReadLine();

string digits = "";
string letters = "";
string otherCharacters = "";

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        digits += input[i];
    }
    else if (char.IsLetter(input[i]))
    {
        letters += input[i];
    }
    else
    {
        otherCharacters += input[i];
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherCharacters);

